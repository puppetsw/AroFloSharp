using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Models;

namespace AroFloSharp.Serialization.Response;

public class LocationsZone : ZoneResponseBase
{
    public override bool IsReadOnly => true;
    public override string[] ValidWheres { get; } =
    {
        "locationid", "linkedtotype", "clientid", "supplierid", "orgid", "clientname", "suppliername", "orgname",
        "locationname", "gpslat", "gpslong", "address", "postcode", "state", "suburb", "country", "archive"
    };

    public override string[] ValidJoins { get; } = { "customfields" };
    public override string[] ValidOrderBys { get; } = { };

    [JsonPropertyName("locations")]
    [XmlArrayItem("location")]
    [XmlArray("locations")]
    public List<Location> Locations { get; set; }
}
