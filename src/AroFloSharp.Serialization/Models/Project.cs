using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace AroFloSharp.Serialization.Models;

public class Project
{
    [JsonPropertyName("status")]
    [XmlElement("status")]
    public string Status { get; set; }

    [JsonPropertyName("client")]
    [XmlElement("client")]
    public Client Client { get; set; }

    [JsonPropertyName("location")]
    [XmlElement("location")]
    public Location Location { get; set; }

    [JsonPropertyName("projectid")]
    [XmlElement("projectid")]
    public string ProjectId { get; set; }

    [JsonPropertyName("projectnumber")]
    [XmlElement("projectnumber")]
    public int ProjectNumber { get; set; }

    [JsonPropertyName("projectname")]
    [XmlElement("projectname")]
    public string ProjectName { get; set; }

    [JsonPropertyName("projecttype")]
    [XmlElement("projecttype")]
    public ProjectType ProjectType { get; set; }

    [JsonPropertyName("custon")]
    [XmlElement("custon")]
    public string CustomerOrderNumber { get; set; }

    [JsonPropertyName("description")]
    [XmlElement("description")]
    public string Description { get; set; }
}
