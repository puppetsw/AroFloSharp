using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Models;

namespace AroFloSharp.Serialization.Response;

public class ContactsZone : ZoneResponseBase
{
    public override bool IsReadOnly => true;
    public override string[] ValidWheres { get; } = { "userid", "archived", "contacttype" };
    public override string[] ValidJoins { get; } = { };
    public override string[] ValidOrderBys { get; } = { };

    [JsonPropertyName("contacts")]
    [XmlArrayItem("contact")]
    [XmlArray("contacts")]
    public List<Contact> Contacts { get; set; }
}
