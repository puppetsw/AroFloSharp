#nullable enable

using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using AroFloSharp.Client.Enums;
using AroFloSharp.Client.Helpers;
using AroFloSharp.Client.Parameters;
using AroFloSharp.Client.Request;

namespace AroFloSharp.Client;

public class AroFloSharpClient : IDisposable
{
    private readonly Configuration _config;
    private readonly HttpClient _httpClient = new();

    public Status Status { get; private set; }

    public string StatusMessage { get; private set; } = string.Empty;

    public AroFloSharpClient(Action<Configuration>? config = null)
    {
        _config = new Configuration();
        config?.Invoke(_config);
        _httpClient.Timeout = _config.Timeout;
    }

    public async Task<string?> GetResponseAsync(Action<ParameterCollection>? parameterCollection)
    {
        var parameters = new ParameterCollection();
        parameterCollection?.Invoke(parameters);

        if (parameters.All(parameter => parameter.GetType() != typeof(ZoneParameter)))
        {
            throw new InvalidOperationException("No ZoneParameter in ParameterCollection");
        }

        using var request = new RequestMessage();
        request.Method = HttpMethod.Get;
        request.Parameters.AddRange(parameters);
        request.RequestUri = new Uri($"{Constants.AROFLO_API_URL}?{request.Parameters}");
        request.AddDefaultHeaders(_config);

        var response = await _httpClient.SendAsync(request);
        var responseString = await response.Content.ReadAsStringAsync();

        var serializer = SerializerHelper.GetSerializer(_config.Accept);
        var responseDeserialized = serializer.Deserialize(responseString);

        Status = responseDeserialized.Status;
        StatusMessage = responseDeserialized.StatusMessage;

        return responseString;
    }

    public void Dispose()
    {
        _httpClient.Dispose();
    }
}
