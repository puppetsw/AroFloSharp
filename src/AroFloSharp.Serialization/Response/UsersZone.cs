using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Models;

namespace AroFloSharp.Serialization.Response;

public class UsersZone : ZoneResponseBase
{
    public override bool IsReadOnly => false;
    public override string[] ValidWheres { get; } = { "userid", "givennames", "surname", "archived" };
    public override string[] ValidJoins { get; } = { "customfields", "permissiongroups" };
    public override string[] ValidOrderBys { get; } = { };

    [JsonPropertyName("users")]
    [XmlArrayItem("user")]
    [XmlArray("users")]
    public List<User> Users { get; set; }
}
