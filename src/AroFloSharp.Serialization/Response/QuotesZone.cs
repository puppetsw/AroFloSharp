using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Models;

namespace AroFloSharp.Serialization.Response;

public class QuotesZone : ZoneResponseBase
{
    public override bool IsReadOnly => true;
    public override string[] ValidWheres { get; } =
    {
        "quoteid", "quotename", "jobnumber", "status", "acceptancestatus", "duedate",
        "datetimedue", "dateapproved", "datetimeapproved"
    };
    public override string[] ValidJoins { get; } = { "documentsandphotos", "lines", "notes", "projects" };
    public override string[] ValidOrderBys { get; } = { "quotename" };

    [JsonPropertyName("quotes")]
    [XmlArrayItem("quote")]
    [XmlArray("quotes")]
    public List<Quote> Quotes { get; set; }
}
