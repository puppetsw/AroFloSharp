using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace AroFloSharp.Serialization.Models;

public class Priority : AroFloObjectBase
{
    [JsonPropertyName("priorityid")]
    [XmlElement("priorityid")]
    public string PriorityId { get; set; }

    [JsonPropertyName("description")]
    [XmlElement("description")]
    public string Description { get; set; }

    [JsonPropertyName("responseminutes")]
    [XmlElement("responseminutes")]
    public string ResponseMinutes { get; set; }

    [JsonPropertyName("archived")]
    [XmlElement("archived")]
    public bool Archived { get; set; }

    [JsonPropertyName("shortdescription")]
    [XmlElement("shortdescription")]
    public string ShortDescription { get; set; }

    [JsonPropertyName("org")]
    [XmlElement("org")]
    public Organization Organization { get; set; }

    [JsonPropertyName("backgroundcolor")]
    [XmlElement("backgroundcolor")]
    public string BackgroundColor { get; set; }

    [JsonPropertyName("responsevalue")]
    [XmlElement("responsevalue")]
    public int ResponseValue { get; set; }

    [JsonPropertyName("responsetype")]
    [XmlElement("responsetype")]
    public string ResponseType { get; set; }
    
    [JsonPropertyName("priorityno")]
    [XmlElement("priorityno")]
    public int ResponseNumber { get; set; }

}
