using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace AroFloSharp.Serialization.Models;

public class TaskLocation
{
    [JsonPropertyName("locationid")]
    [XmlElement("locationid")]
    public string LocationId { get; set; }

    [JsonPropertyName("locationname")]
    [XmlElement("locationname")]
    public string LocationName { get; set; }
}
