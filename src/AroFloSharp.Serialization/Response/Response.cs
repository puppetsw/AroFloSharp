using System.Xml.Serialization;
using Newtonsoft.Json;

namespace AroFloSharp.Serialization.Response;

[XmlRoot("imsapi")]
public class Response<T> where T : ZoneResponseBase
{
    [JsonProperty("status")]
    [XmlElement("status")]
    public string Status { get; set; }

    [JsonProperty("statusmessage")]
    [XmlElement("statusmessage")]
    public string StatusMessage { get; set; }

    [JsonProperty("zoneresponse")]
    [XmlElement("zoneresponse")]
    public T ZoneResponse { get; set; }

}
