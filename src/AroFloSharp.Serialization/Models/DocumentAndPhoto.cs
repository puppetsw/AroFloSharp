using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Helpers;

namespace AroFloSharp.Serialization.Models;

public class DocumentAndPhoto
{
    [JsonPropertyName("documentid")]
    [XmlElement("documentid")]
    public string DocumentId { get; set; }

    [JsonPropertyName("sizeinbytes")]
    [XmlElement("sizeinbytes")]
    public int SizeInBytes { get; set; }

    [JsonPropertyName("uploadeddatetime")]
    [XmlElement("uploadeddatetime")]
    public string UploadDateTimeString
    {
        get => UploadDateTime?.ToString(Constants.DATE_TIME_FORMAT);
        set => UploadDateTime = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? UploadDateTime { get; set; }


    [JsonPropertyName("uploadedbyuser")]
    [XmlElement("uploadedbyuser")]
    public UploadedByUser UploadedByUser { get; set; }

    [JsonPropertyName("filter")]
    [XmlElement("filter")]
    public string Filter { get; set; }

    [JsonPropertyName("comment")]
    [XmlElement("comment")]
    public string Comment { get; set; }

    [JsonPropertyName("url")]
    [XmlElement("url")]
    public string Url { get; set; }

    [JsonPropertyName("name")]
    [XmlElement("name")]
    public string Name { get; set; }
}

public class UploadedByUser
{
    [JsonPropertyName("userid")]
    [XmlElement("userid")]
    public string UserId { get; set; }

    [JsonPropertyName("username")]
    [XmlElement("username")]
    public string Username { get; set; }
}
