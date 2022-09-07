using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AroFloSharp.Serialization.Converters;

public class NullableIntJsonConverter : JsonConverter<int?>
{
    public override int? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var str = reader.GetString();

        if (string.IsNullOrEmpty(str))
        {
            return null;
        }

        return int.Parse(str);
    }

    public override void Write(Utf8JsonWriter writer, int? value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}