using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;
using AroFloSharp.Client.Models;
using AroFloSharp.Client.Responses;

namespace AroFloSharp.Client
{
    public class AroFloSharpClient : IDisposable
    {
        private readonly AroFloSharpOptions _options;
        private readonly HttpClient _httpClient = new HttpClient();
        private readonly CancellationTokenSource _cts = new CancellationTokenSource();

        public AroFloSharpClient(Action<AroFloSharpOptions> options = null)
        {
            _options = new AroFloSharpOptions();

            if (options == null)
            {
                _options.Timeout = TimeSpan.FromSeconds(1);
            }
            else
            {
                options(_options);
            }

            _httpClient.Timeout = _options.Timeout;
        }

        public async Task<IList<Project>> GetProjectsAsync()
        {
            var projects = new List<Project>();

            int page = 1;
            const string requestString = "zone=projects&page=";
            bool morePages = false;
            var uri = new Uri($"{Constants.AROFLO_API_URL}?{requestString}{page}");

            _httpClient.BaseAddress = uri;
            do
            {
                using (var request = new HttpRequestMessage(HttpMethod.Get, uri))
                {
                    request.GenerateHeaders(_options, requestString, page);
                    var response = await _httpClient.SendAsync(request, _cts.Token);

                    var responseString = await response.Content.ReadAsStringAsync();

                    var xml = new XmlSerializer(typeof(AroFloResponse<ProjectZoneResponse>));
                    using (var reader = new StringReader(responseString))
                    {
                        var data = (AroFloResponse<ProjectZoneResponse>)xml.Deserialize(reader);
                        projects.AddRange(data.ZoneResponse.Results);
                        morePages = data.ZoneResponse.IsMorePages;
                        page++;
                    }
                }
            } while (morePages);

            return projects;
        }


        public void Dispose()
        {
            _cts.Dispose();
            _httpClient?.Dispose();
        }
    }
}
