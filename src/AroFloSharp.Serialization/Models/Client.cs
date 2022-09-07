using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Helpers;

namespace AroFloSharp.Serialization.Models;

public class Client : AroFloObjectBase
{
    [JsonPropertyName("contacts")]
    [XmlArrayItem("contact")]
    [XmlArray("contacts")]
    public List<Contact> Contacts { get; set; }

    [JsonPropertyName("locations")]
    [XmlArrayItem("location")]
    [XmlArray("locations")]
    public List<Location> Locations { get; set; }

    [JsonPropertyName("phone")]
    [XmlElement("phone")]
    public string Phone { get; set; }

    [JsonPropertyName("firstname")]
    [XmlElement("firstname")]
    public string FirstName { get; set; }

    [JsonPropertyName("email")]
    [XmlElement("email")]
    public string Email { get; set; }

    [JsonPropertyName("abn")]
    [XmlElement("abn")]
    public string Abn { get; set; }

    [JsonPropertyName("notes")]
    [XmlArrayItem("note")]
    [XmlArray("notes")]
    public List<Note> Notes { get; set; }

    [JsonPropertyName("datetimeinserted")]
    [XmlElement("datetimeinserted")]
    public string DateTimeInsertedString
    {
        get => DateTimeInserted?.ToString(Constants.DATE_TIME_FORMAT);
        set => DateTimeInserted = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? DateTimeInserted { get; set; }

    [JsonPropertyName("documentsandphotos")]
    [XmlArrayItem("documentsandphoto")]
    [XmlArray("documentsandphotos")]
    public List<DocumentAndPhoto> DocumentsAndPhotos { get; set; }

    [JsonPropertyName("link")]
    [XmlElement("link")]
    public ClientLink Link { get; set; }

    [JsonPropertyName("mailingaddress")]
    [XmlElement("mailingaddress")]
    public Address MailingAddress { get; set; }

    [JsonPropertyName("surname")]
    [XmlElement("surname")]
    public string Surname { get; set; }

    [JsonPropertyName("shortname")]
    [XmlElement("shortname")]
    public string ShortName { get; set; }

    [JsonPropertyName("termsnote")]
    [XmlElement("termsnote")]
    public string TermsNote { get; set; }

    [JsonPropertyName("terms")]
    [XmlElement("terms")]
    public string Terms { get; set; }

    [JsonPropertyName("org")]
    [XmlElement("org")]
    public Organization Organization { get; set; }

    [JsonPropertyName("customfields")]
    [XmlArrayItem("customfield")]
    [XmlArray("customfields")]
    public List<CustomField> CustomFields { get; set; }

    [JsonPropertyName("clientid")]
    [XmlElement("clientid")]
    public string ClientId { get; set; }

    [JsonPropertyName("postable")]
    [XmlElement("postable")]
    public bool Postable { get; set; }

    [JsonPropertyName("usecustompriorities")]
    [XmlElement("usecustompriorities")]
    public bool UseCustomPriorities { get; set; }

    [JsonPropertyName("address")]
    [XmlElement("address")]
    public Address Address { get; set; }

    [JsonPropertyName("priorities")]
    [XmlArrayItem("priority")]
    [XmlArray("priorities")]
    public List<Priority> Priorities { get; set; }
    
    [JsonPropertyName("dateinserted")]
    [XmlElement("dateinserted")]
    public string DateInsertedString
    {
        get => DateInserted?.ToString(Constants.DATE_TIME_FORMAT);
        set => DateInserted = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? DateInserted { get; set; }

    [JsonPropertyName("fax")]
    [XmlElement("fax")]
    public string Fax { get; set; }

    [JsonPropertyName("clientname")]
    [XmlElement("clientname")]
    public string ClientName { get; set; }

    [JsonPropertyName("transactionterms")]
    [XmlElement("transactionterms")]
    public TransactionTerm TransactionTerms { get; set; }

    [JsonPropertyName("website")]
    [XmlElement("website")]
    public string Website { get; set; }

    [JsonPropertyName("datecreated")]
    [XmlElement("datecreated")]
    public string DateCreatedString
    {
        get => DateCreated?.ToString(Constants.DATE_FORMAT);
        set => DateCreated = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? DateCreated { get; set; }

    [JsonPropertyName("mobile")]
    [XmlElement("mobile")]
    public string Mobile { get; set; }
}

public class ClientLink
{
    [JsonPropertyName("orgid")]
    [XmlElement("orgid")]
    public string OrgId { get; set; }

    [JsonPropertyName("orgname")]
    [XmlElement("orgname")]
    public string OrgName { get; set; }

    [JsonPropertyName("externalid")]
    [XmlElement("externalid")]
    public string ExternalId { get; set; }
}

