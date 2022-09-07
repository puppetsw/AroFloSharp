using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using AroFloSharp.Serialization.Models;

namespace AroFloSharp.Serialization.Converters;

public class ProjectTypeConverter : JsonConverter<ProjectType>
{
    public override ProjectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String)
        {
            return null;
        }
        var projectType = JsonSerializer.Deserialize<ProjectType>(ref reader);
        return projectType;
    }

    public override void Write(Utf8JsonWriter writer, ProjectType value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}