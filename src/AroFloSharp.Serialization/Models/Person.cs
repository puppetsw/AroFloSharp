using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace AroFloSharp.Serialization.Models;

public class Person : AroFloObjectBase
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
}
