using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Models;

namespace AroFloSharp.Serialization.Response;

public class QuoteLineItemsZone : ZoneResponseBase
{
    public override bool IsReadOnly => true;
    public override string[] ValidWheres { get; } = { "quoteid", "lineid", "parentlineid" };
    public override string[] ValidJoins { get; } = { };
    public override string[] ValidOrderBys { get; } = { };

    [JsonPropertyName("quotelineitems")]
    [XmlArrayItem("quotelineitem")]
    [XmlArray("quotelineitems")]
    public List<QuoteLineItem> QuoteLineItems { get; set; }
}
