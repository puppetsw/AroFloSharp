using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Models;

namespace AroFloSharp.Serialization.Response;

public class TransactionTermsZone : ZoneResponseBase
{
    public override bool IsReadOnly => true;
    public override string[] ValidWheres { get; } = { "transactiontermid" };
    public override string[] ValidJoins { get; } = { };
    public override string[] ValidOrderBys { get; } = { };

    [JsonPropertyName("transactionterms")]
    [XmlArrayItem("transactionterm")]
    [XmlArray("transactionterms")]
    public List<TransactionTerm> TransactionTerms { get; set; }
}
