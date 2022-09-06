using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace AroFloSharp.Serialization.Models;

public class SalesPerson
{
    [JsonPropertyName("givenname")]
    [XmlElement("givenname")]
    public string GivenNames { get; set; }

    [JsonPropertyName("user_id")]
    [XmlElement("user_id")]
    public string UserId { get; set; }

    [JsonPropertyName("surname")]
    [XmlElement("surname")]
    public string Surname { get; set; }
}