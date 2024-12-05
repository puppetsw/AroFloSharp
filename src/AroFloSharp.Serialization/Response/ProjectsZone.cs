using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Models;

namespace AroFloSharp.Serialization.Response;

public sealed class ProjectsZone : ZoneResponseBase
{
    public override bool IsReadOnly => true;
    public override string[] ValidWheres { get; } = { "projectid", "orgid", "projectnumber", "projectname" };
    public override string[] ValidJoins { get; } = { };
    public override string[] ValidOrderBys { get; } = { };

    [JsonPropertyName("projects")]
    [XmlArrayItem("project")]
    [XmlArray("projects")]
    public List<Project> Projects { get; set; }
}
