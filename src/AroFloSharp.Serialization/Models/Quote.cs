using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace AroFloSharp.Serialization.Models;

public class Quote : AroFloObjectBase
{
    [JsonPropertyName("totalinc")]
    [XmlElement("totalinc")]
    public double TotalIncluded { get; set; }

    [JsonPropertyName("totaltax")]
    [XmlElement("totaltax")]
    public double TotalTax { get; set; }

    [JsonPropertyName("totalex")]
    [XmlElement("totalex")]
    public double TotalExcluded { get; set; }

    [JsonPropertyName("estimator")]
    [XmlElement("estimator")]
    public Estimator Estimator { get; set; }
}

public class Estimator : Person { }
