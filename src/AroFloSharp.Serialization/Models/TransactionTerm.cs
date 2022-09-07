using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace AroFloSharp.Serialization.Models;

public class TransactionTerm : AroFloObjectBase
{
    [JsonPropertyName("listorder")]
    [XmlElement("listorder")]
    public int ListOrder { get; set; }

    [JsonPropertyName("transactionterm")]
    [XmlElement("transactionterm")]
    public string TransactionTermText { get; set; }

    [JsonPropertyName("transactiontermnote")]

    [XmlElement("transactiontermnote")]
    public string TransactionTermNote { get; set; }

    [JsonPropertyName("termdays")]
    [XmlElement("termdays")]
    public int? TermDays { get; set; }

    [JsonPropertyName("archived")]
    [XmlElement("archived")]
    [Obsolete("Used in serialization, use Archived property.", false)]
    public string ArchivedString
    {
        get => Archived.ToString();
        set => Archived = bool.Parse(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public bool Archived { get; set; }

    [JsonPropertyName("transactiontermid")]
    [XmlElement("transactiontermid")]
    public string TransactionTermId { get; set; }
}
