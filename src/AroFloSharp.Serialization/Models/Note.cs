using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Helpers;

namespace AroFloSharp.Serialization.Models;

public class Note
{
    [JsonPropertyName("filter")]
    [XmlElement("filter")]
    public string Filter { get; set; }

    [JsonPropertyName("timeposted")]
    [XmlElement("timeposted")]
    public string TimePostedString
    {
        get => TimePosted?.ToString(Constants.TIME_FORMAT);
        set => TimePosted = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? TimePosted { get; set; }

    [JsonPropertyName("noteid")]
    [XmlElement("noteid")]
    public string NoteId { get; set; }

    [JsonPropertyName("content")]
    [XmlElement("content")]
    public string Content { get; set; }

    [JsonPropertyName("dateposted")]
    [XmlElement("dateposted")]
    public string DatePostedString
    {
        get => DatePosted?.ToString(Constants.DATE_FORMAT);
        set => DatePosted = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? DatePosted { get; set; }

    // User
}
