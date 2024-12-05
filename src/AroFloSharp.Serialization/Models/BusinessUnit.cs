using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace AroFloSharp.Serialization.Models;

public class BusinessUnit : AroFloObjectBase
{
    [JsonPropertyName("orgid")]
    [XmlElement("orgid")]
    public string OrgId { get; set; }

    [JsonPropertyName("mailingaddress")]
    [XmlElement("mailingaddress")]
    public Address MailingAddress { get; set; }

    [JsonPropertyName("surname")]
    [XmlElement("surname")]
    public string Surname { get; set; }

    [JsonPropertyName("locations")]
    [XmlArrayItem("location")]
    [XmlArray("locations")]
    public List<Location> Locations { get; set; }

    [JsonPropertyName("shortname")]
    [XmlElement("shortname")]
    public string ShortName { get; set; }

    [JsonPropertyName("termsnote")]
    [XmlElement("termsnote")]
    public string TermsNote { get; set; }

    [JsonPropertyName("phone")]
    [XmlElement("phone")]
    public string Phone { get; set; }

    [JsonPropertyName("terms")]
    [XmlElement("terms")]
    public string Terms { get; set; }

    [JsonPropertyName("firstname")]
    [XmlElement("firstname")]
    public string FirstName { get; set; }

    [JsonPropertyName("email")]
    [XmlElement("email")]
    public string Email { get; set; }

    [JsonPropertyName("abn")]
    [XmlElement("abn")]
    public string ABN { get; set; }

    [JsonPropertyName("businessunitname")]
    [XmlElement("businessunitname")]
    public string BusinessUnitName { get; set; }

    [JsonPropertyName("usecustompriorities")]
    [XmlElement("usecustompriorities")]
    public string UseCustomPrioritiesString
    {
        get => UseCustomPriorities.ToString();
        set => UseCustomPriorities = bool.Parse(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public bool UseCustomPriorities { get; set; }

    [JsonPropertyName("address")]
    [XmlElement("address")]
    public Address Address { get; set; }

    [JsonPropertyName("priorities")]
    [XmlArrayItem("priority")]
    [XmlArray("priorities")]
    public List<Priority> Priorities { get; set; }

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

    [JsonPropertyName("fax")]
    [XmlElement("fax")]
    public string Fax { get; set; }

    [JsonPropertyName("website")]
    [XmlElement("website")]
    public string Website { get; set; }

    [JsonPropertyName("mobile")]
    [XmlElement("mobile")]
    public string Mobile { get; set; }
}
