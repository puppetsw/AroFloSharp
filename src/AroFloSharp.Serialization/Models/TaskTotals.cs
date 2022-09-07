using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace AroFloSharp.Serialization.Models;

public class TaskTotals
{
    [JsonPropertyName("totalmat")]
    [XmlElement("totalmat")]
    public double TotalMaterial { get; set; }

    [JsonPropertyName("totallab")]
    [XmlElement("totallab")]
    public double TotalLabour { get; set; }

    [JsonPropertyName("totalexp")]
    [XmlElement("totalexp")]
    public double TotalExpenses { get; set; }

    [JsonPropertyName("totalhrs")]
    [XmlElement("totalhrs")]
    public double TotalHours { get; set; }
}
