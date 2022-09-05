using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Models;

namespace AroFloSharp.Serialization.Response;

public class LastUpdateZone : ZoneResponseBase
{
    public override bool IsReadOnly => true;

    public override string[] ValidWhereFilters { get; } = { "zonename", "lastupdateutc" };

    public override string[] ValidJoins { get; } = { };

    [JsonPropertyName("lastupdate")]
    [XmlArrayItem("lastupdate")]
    [XmlArray("lastupdate")]
    public List<LastUpdate> LastUpdate { get; set; }
}
