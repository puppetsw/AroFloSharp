using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace AroFloSharp.Serialization.Models;

public class Contact : AroFloObjectBase
{
    [JsonPropertyName("givennames")]
    [XmlElement("givennames")]
    public string GivenNames { get; set; }

    [JsonPropertyName("userid")]
    [XmlElement("userid")]
    public string UserId { get; set; }

    [JsonPropertyName("surname")]
    [XmlElement("surname")]
    public string Surname { get; set; }

    [JsonPropertyName("phone")]
    [XmlElement("phone")]
    public string Phone { get; set; }

    [JsonPropertyName("fax")]
    [XmlElement("fax")]
    public string Fax { get; set; }

    [JsonPropertyName("username")]
    [XmlElement("username")]
    public string Username { get; set; }

    [JsonPropertyName("email")]
    [XmlElement("email")]
    public string Email { get; set; }

    [JsonPropertyName("email2")]
    [XmlElement("email2")]
    public string Email2 { get; set; }

    [JsonPropertyName("mobile")]
    [XmlElement("mobile")]
    public string Mobile { get; set; }

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

    [JsonPropertyName("org")]
    [XmlElement("org")]
    public Organization Organization { get; set; }

    [JsonPropertyName("contacttype")]
    [XmlElement("contacttype")]
    public string ContactType { get; set; }

    [JsonPropertyName("customfields")]
    [XmlArrayItem("customfield")]
    [XmlArray("customfields")]
    public List<CustomField> CustomFields { get; set; }

    [JsonPropertyName("notes")]
    [XmlArrayItem("note")]
    [XmlArray("notes")]
    public List<Note> Notes { get; set; }

    [JsonPropertyName("accesstype")]
    [XmlElement("accesstype")]
    public string AccessType { get; set; }

    [JsonPropertyName("documentsandphotos")]
    [XmlArrayItem("documentandphoto")]
    [XmlArray("documentsandphotos")]
    public List<DocumentAndPhoto> DocumentsAndPhotos { get; set; }
}
