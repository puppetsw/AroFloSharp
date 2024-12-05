using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace AroFloSharp.Serialization.Models;

public class Location : AroFloObjectBase
{
    [JsonPropertyName("locationid")]
    [XmlElement("locationid")]
    public string LocationId { get; set; }

    [JsonPropertyName("locationname")]
    [XmlElement("locationname")]
    public string LocationName { get; set; }

    [JsonPropertyName("gpslat")]
    [XmlElement("gpslat")]
    public double Latitude { get; set; }

    [JsonPropertyName("gpslong")]
    [XmlElement("gpslong")]
    public double Longitude { get; set; }

    [JsonPropertyName("postcode")]
    [XmlElement("postcode")]
    public string PostCode { get; set; }

    [JsonPropertyName("state")]
    [XmlElement("state")]
    public string State { get; set; }

    [JsonPropertyName("country")]
    [XmlElement("country")]
    public string Country { get; set; }

    [JsonPropertyName("suburb")]
    [XmlElement("suburb")]
    public string Suburb { get; set; }

    [JsonPropertyName("archived")]
    [XmlElement("archived")]
    [Obsolete("Use the IsArchived property.", false)]
    [Browsable(false)]
    public string ArchivedString { get; set; }

#pragma warning disable CS0618
    [JsonIgnore]
    [XmlIgnore]
    public bool IsArchived
    {
        get
        {
            if (string.IsNullOrEmpty(ArchivedString))
            {
                return false;
            }

            switch (ArchivedString.ToLower())
            {
                case "false":
                    return false;
                case "true":
                    return true;
                default:
                    throw new InvalidOperationException("ArchivedString was invalid.");
            }
        }
    }
#pragma warning restore CS0618

    [JsonPropertyName("address")]
    [XmlElement("address")]
    public string Address { get; set; }

    [JsonPropertyName("customfields")]
    [XmlArrayItem("customfield")]
    [XmlArray("customfields")]
    public List<CustomField> CustomFields { get; set; }

    [JsonPropertyName("notes")]
    [XmlArrayItem("note")]
    [XmlArray("notes")]
    public List<Note> Notes { get; set; }

    [JsonPropertyName("SiteEmail")]
    [XmlElement("siteemail")]
    public string SiteEmail { get; set; }

    [JsonPropertyName("SitePhone")]
    [XmlElement("sitephone")]
    public string SitePhone { get; set; }

    [JsonPropertyName("SiteContact")]
    [XmlElement("sitecontact")]
    public string SiteContact { get; set; }

    [JsonPropertyName("documentsandphotos")]
    [XmlArrayItem("documentandphoto")]
    [XmlArray("documentsandphotos")]
    public List<DocumentAndPhoto> DocumentsAndPhotos { get; set; }

    [JsonPropertyName("linkedto")]
    [XmlElement("linkedto")]
    public LinkedTo LinkedTo { get; set; }
}

public class LinkedTo
{
    [JsonPropertyName("linkedtoname")]
    [XmlElement("linkedtoname")]
    public string Name { get; set; }

    [JsonPropertyName("linkedtoid")]
    [XmlElement("linkedtoid")]
    public string Id { get; set; }

    [JsonPropertyName("linkedtotype")]
    [XmlElement("linkedtotype")]
    public string Type { get; set; }
}
