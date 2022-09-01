using System.IO;
using System.Xml.Serialization;

#nullable enable

namespace AroFloSharp.Serialization.Serializer;

public static class XmlNetSerializer
{
    public static string ContentType { get; } = "application/xml";

    public static string? Serialize(object? obj)
    {
        if (obj == null)
        {
            return null;
        }

        using var textWriter = new StringWriter();

        var serializer = new XmlSerializer(obj.GetType());
        serializer.Serialize(textWriter, obj);

        return textWriter.ToString();
    }

    public static T? Deserialize<T>(string? response)
    {
        if (string.IsNullOrEmpty(response))
        {
            return default;
        }

        using var textReader = new StringReader(response);
        var serializer = new XmlSerializer(typeof(T));

        return (T)serializer.Deserialize(textReader);
    }
}
