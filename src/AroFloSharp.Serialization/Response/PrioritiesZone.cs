using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Models;

namespace AroFloSharp.Serialization.Response;

public class PrioritiesZone : ZoneResponseBase
{
    public override bool IsReadOnly => false;
    public override string[] ValidWheres { get; } = { "orgid", "priorityid", "archived" };
    public override string[] ValidJoins { get; } = { };
    public override string[] ValidOrderBys { get; } = { };

    [JsonPropertyName("priorities")]
    [XmlArrayItem("priority")]
    [XmlArray("priorities")]
    public List<Priority> Priorities { get; set; }
}
