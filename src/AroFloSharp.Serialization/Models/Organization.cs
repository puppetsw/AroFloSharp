using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace AroFloSharp.Serialization.Models;

public class Organization
{
    [JsonPropertyName("orgid")]
    [XmlElement("orgid")]
    public string OrgId { get; set; }

    [JsonPropertyName("orgname")]
    [XmlElement("orgname")]
    public string OrgName { get; set; }
}
