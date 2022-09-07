using System.ComponentModel;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace AroFloSharp.Serialization.Models;

public class CustomField
{
    [JsonPropertyName("fieldid")]
    [XmlElement("fieldid")]
    public string FieldId { get; set; }

    [JsonPropertyName("value")]
    [XmlElement("value")]
    public string Value { get; set; }

    [JsonPropertyName("archived")]
    [XmlElement("archived")]
    [Browsable(false)]
    public string ArchivedString
    {
        get => Archived.ToString();
        set => Archived = bool.Parse(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public bool Archived { get; set; }

    [JsonPropertyName("type")]
    [XmlElement("type")]
    public string Type { get; set; }

    [JsonPropertyName("name")]
    [XmlElement("name")]
    public string Name { get; set; }
}
