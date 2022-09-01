using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace AroFloSharp.Serialization.Response;

[XmlRoot("imsapi")]
public class Response<T> where T : ZoneResponseBase
{
    [JsonPropertyName("status")]
    [XmlElement("status")]
    public string Status { get; set; }

    [JsonPropertyName("statusmessage")]
    [XmlElement("statusmessage")]
    public string StatusMessage { get; set; }

    [JsonPropertyName("zoneresponse")]
    [XmlElement("zoneresponse")]
    public T ZoneResponse { get; set; }

}
