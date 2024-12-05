using System;
using System.ComponentModel;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Helpers;

namespace AroFloSharp.Serialization.Models;

public class Expense
{
    [JsonPropertyName("cost")]
    [XmlElement("cost")]
    public double Cost { get; set; }

    [JsonPropertyName("sell")]
    [XmlElement("sell")]
    public double Sell { get; set; }

    [JsonPropertyName("description")]
    [XmlElement("description")]
    public string Description { get; set; }

    [JsonPropertyName("quantity")]
    [XmlElement("quantity")]
    public int Quantity { get; set; }

    [JsonPropertyName("lineid")]
    [XmlElement("lineid")]
    public string LineId { get; set; }

    [JsonPropertyName("dateused")]
    [XmlElement("dateused")]
    [Browsable(false)]
    public string DateUsedString
    {
        get => DateUsed?.ToString(Constants.DATE_FORMAT);
        set => DateUsed = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? DateUsed { get; set; }

    [JsonPropertyName("user")]
    [XmlElement("user")]
    public TaskUser User { get; set; }
}
