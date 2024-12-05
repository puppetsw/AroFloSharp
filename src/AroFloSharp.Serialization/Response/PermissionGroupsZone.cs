using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Models;

namespace AroFloSharp.Serialization.Response;

public class PermissionGroupsZone : ZoneResponseBase
{
    public override bool IsReadOnly => true;
    public override string[] ValidWheres { get; } = { };
    public override string[] ValidJoins { get; } = { };
    public override string[] ValidOrderBys { get; } = { };

    [JsonPropertyName("permissiongroups")]
    [XmlArrayItem("permissiongroup")]
    [XmlArray("permissiongroups")]
    public List<PermissionGroup> PermissionGroups { get; set; }
}
