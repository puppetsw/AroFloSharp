using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace AroFloSharp.Serialization.Models;

public class QuoteLineItem : LineItem
{
    [JsonPropertyName("quote")]
    [XmlElement("quote")]
    public Quote Quote { get; set; }
}
