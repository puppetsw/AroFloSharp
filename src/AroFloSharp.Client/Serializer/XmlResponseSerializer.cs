using System.IO;
using System.Xml.Serialization;
using AroFloSharp.Client.Response;

namespace AroFloSharp.Client.Serializer;

public class XmlResponseSerializer : ISerializer
{
    private readonly XmlSerializer _serializer;

    public XmlResponseSerializer() => _serializer = new XmlSerializer(typeof(RequestResponse));

    public RequestResponse Deserialize(string response)
    {
        using var textReader = new StringReader(response);

        return (RequestResponse)_serializer.Deserialize(textReader);
    }
}