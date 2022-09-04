#nullable enable

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Models;
using AroFloSharp.Serialization.Response;

namespace AroFloSharp.Serialization.Serializer;

public static class XmlNetSerializer
{
    private const string ARRAY_OF = "ArrayOf";

    private static readonly XmlWriterSettings s_xmlWriterSettings = new() { OmitXmlDeclaration = true };

    private static readonly XmlSerializerNamespaces s_xmlSerializerNamespaces = new(new[] { XmlQualifiedName.Empty });

    /// <summary>
    /// Serialize Model into Postable XML.
    /// </summary>
    /// <typeparam name="T"/>
    /// <param name="model">The <see cref="AroFloObjectBase"/> object to be serialized.</param>
    /// <returns>A <see cref="string"/> containing <c>postxml</c> for AroFlo.</returns>
    public static string? Serialize<T>(T? model) where T : AroFloObjectBase
    {
        if (model == null)
        {
            return null;
        }

        var list = new List<T> { model };
        var serializer = new XmlSerializer(list.GetType());

        using var stream = new StringWriter();
        using var writer = XmlWriter.Create(stream, s_xmlWriterSettings);

        serializer.Serialize(writer, list, s_xmlSerializerNamespaces);

        // Replace ArrayOf string with the zones name.
        // i.e. ArrayOfProject becomes Projects, ArrayOfClient becomes Clients
        var objectName = typeof(T).Name;
        var xml = stream.ToString();
        return RemoveArrayOf(xml, objectName);
    }

    public static string? Serialize<T>(IEnumerable<T>? models) where T : AroFloObjectBase
    {
        if (models is null)
        {
            return null;
        }

        var list = new List<T>();
        list.AddRange(models);

        if (list.Any(x => x.GetType() != list.First().GetType()))
        {
            throw new InvalidOperationException("Multiple types in IEnumerable<T>");
        }

        var serializer = new XmlSerializer(list.GetType());

        using var stream = new StringWriter();
        using var writer = XmlWriter.Create(stream, s_xmlWriterSettings);

        serializer.Serialize(writer, list, s_xmlSerializerNamespaces);

        // Replace ArrayOf string with the zones name.
        // i.e. ArrayOfProject becomes Projects, ArrayOfClient becomes Clients
        var objectName = typeof(T).Name;
        var xml = stream.ToString();
        return RemoveArrayOf(xml, objectName);
    }

    private static string RemoveArrayOf(string str, string objectName)
    {
        return str.Replace($"{ARRAY_OF}{objectName}", $"{objectName}s");
    }

    /// <summary>
    /// Deserialize response XML into a <see cref="AroFloObjectBase"/> model of type <see cref="T"/>.
    /// </summary>
    /// <typeparam name="T"/>
    /// <param name="response">The response XML string.</param>
    /// <returns>Model of type <see cref="T"/>.</returns>
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
