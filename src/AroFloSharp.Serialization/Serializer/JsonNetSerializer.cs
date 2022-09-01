using System.Text.Json;
using System.Text.Json.Serialization;

#nullable enable

namespace AroFloSharp.Serialization.Serializer;

public static class JsonNetSerializer
{
    public static string ContentType { get; } = "application/json";

    public static readonly JsonSerializerOptions JsonSerializerOptions = new()
    {
        NumberHandling = JsonNumberHandling.AllowReadingFromString
    };

    public static string? Serialize(object? data)
    {
        return JsonSerializer.Serialize(data, JsonSerializerOptions);
    }

    public static T? Deserialize<T>(string? response)
    {
        if (response is null)
        {
            return default;
        }

        return JsonSerializer.Deserialize<T>(response, JsonSerializerOptions);
    }
}
