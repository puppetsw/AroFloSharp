using System.Text.Json;
using System.Text.Json.Serialization;
using AroFloSharp.Serialization.Response;

#nullable enable

namespace AroFloSharp.Serialization.Serializer;

public static class JsonNetSerializer
{
    public static string ContentType { get; } = "application/json";

    public static readonly JsonSerializerOptions JsonSerializerOptions = new()
    {
        NumberHandling = JsonNumberHandling.AllowReadingFromString
    };

    public static Response<T>? Deserialize<T>(string? response) where T : ZoneResponseBase
    {
        if (response is null)
        {
            return default;
        }

        return JsonSerializer.Deserialize<Response<T>>(response, JsonSerializerOptions);
    }
}
