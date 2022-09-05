using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Models;

namespace AroFloSharp.Serialization.Response;

public class BusinessUnitsZone : ZoneResponseBase
{
    public override bool IsReadOnly => true;
    public override string[] ValidWhereFilters { get; } = { "orgid", "archived", "businessunitname" };
    public override string[] ValidJoins { get; } = { "locations", "priorities" };

    [JsonPropertyName("businessunits")]
    [XmlArrayItem("businessunit")]
    [XmlArray("businessunits")]
    public List<BusinessUnit> BusinessUnits { get; set; }
}
