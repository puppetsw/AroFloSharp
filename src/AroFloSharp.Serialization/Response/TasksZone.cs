using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Models;

namespace AroFloSharp.Serialization.Response;

public class TasksZone : ZoneResponseBase
{
    public override bool IsReadOnly => false;
    public override string[] ValidWhereFilters { get; } // TODO
    public override string[] ValidJoins { get; } // TODO

    [JsonPropertyName("tasks")]
    [XmlArrayItem("task")]
    [XmlArray("tasks")]
    public List<Task> Tasks { get; set; }
}
