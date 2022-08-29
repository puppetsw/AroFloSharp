using System;
using System.Net.Http;
using System.Threading.Tasks;
using AroFloSharp.Client.Parameters;
using AroFloSharp.Client.Request;

namespace AroFloSharp.Client;

public class AroFloSharpClient : IDisposable
{
    private readonly AroFloSharpConfig _config;
    private readonly HttpClient _httpClient = new();

    public AroFloSharpClient(Action<AroFloSharpConfig> config = null)
    {
        _config = new AroFloSharpConfig();
        config?.Invoke(_config);
        _httpClient.Timeout = _config.Timeout;
    }

    public async Task<string> GetResponseAsync(Action<ParameterCollection> parameterCollection)
    {
        var parameters = new ParameterCollection();
        parameterCollection?.Invoke(parameters);

        using var request = new RequestMessage();
        request.Parameters.AddRange(parameters);
        request.RequestUri = new Uri($"{Constants.AROFLO_API_URL}?{request.Parameters}");
        request.AddDefaultHeaders(_config);

        var response = await _httpClient.SendAsync(request);
        var responseString = await response.Content.ReadAsStringAsync();

        return responseString;
    }

    public void Dispose()
    {
        _httpClient?.Dispose();
    }
}