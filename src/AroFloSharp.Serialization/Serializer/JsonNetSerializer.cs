#nullable enable

using System;
using System.Globalization;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace AroFloSharp.Serialization.Serializer;

public class JsonNetSerializer : IDisposable
{
    private readonly JsonSerializer _serializer;

    private readonly StringWriter _stringWriter = new(new StringBuilder(256), CultureInfo.InvariantCulture);

    private readonly JsonTextWriter _jsonTextWriter;

    private static readonly JsonSerializerSettings s_defaultSettings = new()
    {
        ContractResolver     = new CamelCasePropertyNamesContractResolver(),
        DefaultValueHandling = DefaultValueHandling.Include,
        TypeNameHandling     = TypeNameHandling.None,
        NullValueHandling    = NullValueHandling.Ignore,
        Formatting           = Formatting.None,
        ConstructorHandling  = ConstructorHandling.AllowNonPublicDefaultConstructor
    };

    /// <summary>
    /// Create the new serializer that uses JsonNewtonsoft with default settings
    /// </summary>
    public JsonNetSerializer()
    {
        _serializer = JsonSerializer.Create(s_defaultSettings);

        _jsonTextWriter = new(_stringWriter)
        {
            Formatting = _serializer.Formatting,
            CloseOutput = false
        };
    }

    public string? Serialize(object? obj) {
        if (obj == null) return null;

        _serializer.Serialize(_jsonTextWriter, obj, obj.GetType());

        return _stringWriter.ToString();
    }

    public T? Deserialize<T>(string response)
    {
        using var reader = new JsonTextReader(new StringReader(response)) { CloseInput = true };
        return _serializer.Deserialize<T>(reader);
    }

    public void Dispose()
    {
        _stringWriter.GetStringBuilder().Clear();
        _stringWriter.Dispose();
    }
}