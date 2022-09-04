#nullable enable

using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Models;
using AroFloSharp.Serialization.Response;

namespace AroFloSharp.Serialization.Serializer;

public static class XmlNetSerializer
{
    private const string ARRAY_OF = "ArrayOf";

    private static readonly XmlWriterSettings s_xmlWriterSettings = new()
    {
        OmitXmlDeclaration = true
    };

    private static readonly XmlSerializerNamespaces s_xmlSerializerNamespaces = new(new[] { XmlQualifiedName.Empty });

    /// <summary>
    /// Serialize Model into Postable XML.
    /// </summary>
    /// <typeparam name="T"/>
    /// <param name="obj">The <see cref="AroFloObjectBase"/> object to be serialized.</param>
    /// <returns>A <see cref="string"/> containing <c>postxml</c> for AroFlo.</returns>
    public static string? Serialize<T>(T? obj) where T : AroFloObjectBase
    {
        if (obj == null)
        {
            return null;
        }

        var list = new List<T> { obj };
        var serializer = new XmlSerializer(list.GetType());

        using var stream = new StringWriter();
        using var writer = XmlWriter.Create(stream, s_xmlWriterSettings);

        serializer.Serialize(writer, list, s_xmlSerializerNamespaces);

        // Replace ArrayOf string with the zones name.
        // i.e. ArrayOfProject becomes Projects, ArrayOfClient becomes Clients
        var objectName = typeof(T).Name;
        var xml = stream.ToString();
        var formatted = xml.Replace($"{ARRAY_OF}{objectName}", $"{objectName}s");
        return formatted;
    }

    public static Response<T>? Deserialize<T>(string? response) where T : ZoneResponseBase
    {
        if (string.IsNullOrEmpty(response))
        {
            return default;
        }

        var serializationType = typeof(Response<T>);

        using var textReader = new StringReader(response);
        var serializer = new XmlSerializer(serializationType);

        return (Response<T>?)serializer.Deserialize(textReader);
    }
}
