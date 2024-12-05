using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace AroFloSharp.Serialization.Models;

public class Stage
{
    [JsonPropertyName("stageid")]
    [XmlElement("stageid")]
    public string StageId { get; set; }

    [JsonPropertyName("stagename")]
    [XmlElement("stagename")]
    public string StageName { get; set; }
}
