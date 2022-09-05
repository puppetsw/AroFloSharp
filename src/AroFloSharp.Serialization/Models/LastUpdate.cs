using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace AroFloSharp.Serialization.Models;

public class LastUpdate : AroFloObjectBase
{
    [JsonPropertyName("zoneid")]
    [XmlElement("zoneid")]
    public string ZoneId { get; set; }

    [JsonPropertyName("zonename")]
    [XmlElement("zonename")]
    public string ZoneName { get; set; }

    [JsonPropertyName("zoneidreference")]
    [XmlElement("zoneidreference")]
    public string ZoneIdReference { get; set; }

    [JsonPropertyName("lastupdateutc")]
    [XmlElement("lastupdateutc")]
    public DateTime LastUpdateUtc { get; set; }
}