#nullable enable

using System.Text.Json;
using System.Text.Json.Serialization;
using AroFloSharp.Serialization.Converters;
using AroFloSharp.Serialization.Response;

namespace AroFloSharp.Serialization.Serializer;

public static class JsonNetSerializer
{
    private static readonly JsonSerializerOptions s_jsonSerializerOptions = new()
    {
        NumberHandling = JsonNumberHandling.AllowReadingFromString,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
        Converters = { new DateTimeJsonConverter(),
                       new BooleanJsonConverter(),
                       new StringJsonConverter(),
                       new NullableIntJsonConverter()
        }
    };

    public static Response<T>? Deserialize<T>(string? response) where T : ZoneResponseBase
    {
        if (response is null)
        {
            return default;
        }

        return JsonSerializer.Deserialize<Response<T>>(response, s_jsonSerializerOptions);
    }
}
