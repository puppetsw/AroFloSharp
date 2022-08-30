using System;
using System.Globalization;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

#nullable enable

namespace AroFloSharp.Serialization.Serializer;

public class JsonNewtonsoftSerializer : IDisposable
{
    private readonly JsonSerializer _serializer;

    private readonly StringWriter _stringWriter = new(new StringBuilder(256), CultureInfo.InvariantCulture);

    private readonly JsonTextWriter _jsonTextWriter;

    public string ContentType { get; set; } = "application/json";

    public static readonly JsonSerializerSettings DefaultSettings = new()
    {
        ContractResolver     = new CamelCasePropertyNamesContractResolver(),
        DefaultValueHandling = DefaultValueHandling.Include,
        TypeNameHandling     = TypeNameHandling.None,
        NullValueHandling    = NullValueHandling.Ignore,
        Formatting           = Formatting.None,
        ConstructorHandling  = ConstructorHandling.AllowNonPublicDefaultConstructor
    };

    public JsonNewtonsoftSerializer(JsonSerializerSettings serializerSettings)
    {
        _serializer = JsonSerializer.Create(serializerSettings);

        _jsonTextWriter = new(_stringWriter)
        {
            Formatting = _serializer.Formatting,
            CloseOutput = false
        };
    }

    /// <summary>
    /// Create the new serializer that uses JsonNewtonsoft with default settings
    /// </summary>
    public JsonNewtonsoftSerializer() : this(DefaultSettings) { }

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
