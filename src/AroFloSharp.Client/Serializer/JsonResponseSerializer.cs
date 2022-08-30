using System.Text.Json;
using AroFloSharp.Client.Response;

namespace AroFloSharp.Client.Serializer;

public class JsonResponseSerializer : ISerializer
{
    public RequestResponse Deserialize(string response)
    {
        return JsonSerializer.Deserialize<RequestResponse>(response);
    }
}