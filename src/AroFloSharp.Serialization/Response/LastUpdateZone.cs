using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Models;

namespace AroFloSharp.Serialization.Response;

public class LastUpdateZone : ZoneResponseBase
{
    public override bool IsReadOnly => true;
    public override string[] ValidWheres { get; } = { "zonename", "lastupdateutc" };
    public override string[] ValidJoins { get; } = { };
    public override string[] ValidOrderBys { get; } = { };

    [JsonPropertyName("lastupdate")]
    [XmlArrayItem("lastupdate")]
    [XmlArray("lastupdate")]
    public List<LastUpdate> LastUpdate { get; set; }
}
