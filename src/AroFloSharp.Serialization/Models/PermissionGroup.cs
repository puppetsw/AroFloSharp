using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace AroFloSharp.Serialization.Models;

public class PermissionGroup
{
    [JsonPropertyName("groupid")]
    [XmlElement("groupid")]
    public string GroupId { get; set; }

    [JsonPropertyName("groupname")]
    [XmlElement("groupname")]
    public string GroupName { get; set; }

    [JsonPropertyName("archived")]
    [XmlElement("archived")]
    public string ArchivedString
    {
        get => Archived.ToString();
        set => Archived = bool.Parse(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public bool Archived { get; set; }
}
