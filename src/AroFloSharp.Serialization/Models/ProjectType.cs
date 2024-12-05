using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace AroFloSharp.Serialization.Models;

public class ProjectType
{
    [JsonPropertyName("projecttypeid")]
    [XmlElement("projecttypeid")]
    public string Id { get; set; }

    [JsonPropertyName("projecttype")]
    [XmlElement("projecttype")]
    public string Type { get; set; }
}