using System.Xml.Serialization;
using Newtonsoft.Json;

namespace AroFloSharp.Serialization.Models;

public class Project
{
    [JsonProperty("status")]
    [XmlElement("status")]
    public string Status { get; set; }

    [JsonProperty("client")]
    [XmlElement("client")]
    public Client Client { get; set; }

    [JsonProperty("location")]
    [XmlElement("location")]
    public Location Location { get; set; }

    [JsonProperty("projectid")]
    [XmlElement("projectid")]
    public string ProjectId { get; set; }

    [JsonProperty("projectnumber")]
    [XmlElement("projectnumber")]
    public int ProjectNumber { get; set; }

    [JsonProperty("projectname")]
    [XmlElement("projectname")]
    public string ProjectName { get; set; }

    [JsonProperty("projecttype")]
    [XmlElement("projecttype")]
    public ProjectType ProjectType { get; set; }

    [JsonProperty("custon")]
    [XmlElement("custon")]
    public string CustomerOrderNumber { get; set; }

    [JsonProperty("description")]
    [XmlElement("description")]
    public string Description { get; set; }
}
