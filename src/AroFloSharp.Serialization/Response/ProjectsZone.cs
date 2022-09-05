using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Models;

namespace AroFloSharp.Serialization.Response;

public sealed class ProjectsZone : ZoneResponseBase
{
    public override bool IsReadOnly => true;
    public override string[] ValidWhereFilters { get; } = { "projectid", "orgid", "projectnumber", "projectname" };
    public override string[] ValidJoins { get; } = { };

    [JsonPropertyName("projects")]
    [XmlArrayItem("project")]
    [XmlArray("projects")]
    public List<Project> Projects { get; set; }
}
