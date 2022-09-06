using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Models;

namespace AroFloSharp.Serialization.Response;

public class UsersZone : ZoneResponseBase
{
    public override bool IsReadOnly => false;
    public override string[] ValidWhereFilters { get; } = { "userid", "givennames", "surname", "archived" };
    public override string[] ValidJoins { get; } = { "customfields", "permissiongroups" };

    [JsonPropertyName("users")]
    [XmlArrayItem("user")]
    [XmlArray("users")]
    public List<User> Users { get; set; }
}
