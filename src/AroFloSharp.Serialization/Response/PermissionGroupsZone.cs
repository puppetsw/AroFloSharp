using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Models;

namespace AroFloSharp.Serialization.Response;

public class PermissionGroupsZone : ZoneResponseBase
{
    public override bool IsReadOnly => true;
    public override string[] ValidWhereFilters { get; } = { };
    public override string[] ValidJoins { get; } = { };

    [JsonPropertyName("permissiongroups")]
    [XmlArrayItem("permissiongroup")]
    [XmlArray("permissiongroups")]
    public List<PermissionGroup> PermissionGroups { get; set; }
}
