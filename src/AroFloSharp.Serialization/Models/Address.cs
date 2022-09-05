using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace AroFloSharp.Serialization.Models;

public sealed class Address
{
    [JsonPropertyName("country")]
    [XmlElement("country")]
    public string Country { get; set; }

    [JsonPropertyName("postcode")]
    [XmlElement("postcode")]
    public string Postcode { get; set; }

    [JsonPropertyName("addressline1")]
    [XmlElement("addressline1")]
    public string AddressLine1 { get; set; }

    [JsonPropertyName("addressline2")]
    [XmlElement("addressline2")]
    public string AddressLine2 { get; set; }

    [JsonPropertyName("state")]
    [XmlElement("state")]
    public string State { get; set; }

    [JsonPropertyName("suburb")]
    [XmlElement("suburb")]
    public string Suburb { get; set; }
}
