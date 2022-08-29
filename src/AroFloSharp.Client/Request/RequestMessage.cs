using System.Net.Http;
using AroFloSharp.Client.Parameters;

#nullable enable

namespace AroFloSharp.Client.Request;
public class RequestMessage : HttpRequestMessage
{
    public ParameterCollection Parameters { get; } = new();

    public RequestMessage()
    {
        Method = HttpMethod.Get;
    }

    public RequestMessage(ParameterCollection parameters)
    {
        Parameters = parameters;
    }
}
