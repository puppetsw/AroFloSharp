using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Models;

namespace AroFloSharp.Serialization.Response;

public class ClientsZone : ZoneResponseBase
{
    public override bool IsReadOnly => false;
    public override string[] ValidWheres { get; } =
    {
        "clientid", "archived", "clientname", "postable", "datecreated",
        "dateinserted", "datetimeinserted"
    };

    public override string[] ValidJoins { get; } =
    {
        "locations", "locationcustomfields", "contacts", "customfields", "priorities"
    };
    public override string[] ValidOrderBys { get; } = { };

    [JsonPropertyName("clients")]
    [XmlArrayItem("client")]
    [XmlArray("clients")]
    public List<Client> Clients { get; set; }
}
