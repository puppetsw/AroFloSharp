using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Models;

namespace AroFloSharp.Serialization.Response;

public sealed class ProjectZone : ZoneResponseBase
{
    [JsonPropertyName("projects")]
    [XmlArrayItem("project")]
    [XmlArray("projects")]
    public List<Project> Projects { get; set; }

    public override bool IsReadOnly => true;

    public override string[] ValidWhereFilters { get; } = { "projectid", "orgid", "projectnumber", "projectname" };
}
