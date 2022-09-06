using System;
using System.ComponentModel;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Helpers;

namespace AroFloSharp.Serialization.Models;

public class Material
{
    [JsonPropertyName("matlinkprocesseddatetime")]
    [XmlElement("matlinkprocesseddatetime")]
    [Browsable(false)]
    public string MaterialLinkProcessedDateTimeString
    {
        get => MaterialLinkProcessedDateTime?.ToString(Constants.DATE_TIME_FORMAT);
        set => MaterialLinkProcessedDateTime = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? MaterialLinkProcessedDateTime { get; set; }

    [JsonPropertyName("matlinkprocesseddate")]
    [XmlElement("matlinkprocesseddate")]
    [Browsable(false)]
    public string MaterialLinkProcessedDateString
    {
        get => MaterialLinkProcessedDate?.ToString(Constants.DATE_FORMAT);
        set => MaterialLinkProcessedDate = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? MaterialLinkProcessedDate { get; set; }

    [JsonPropertyName("matlinkprocessed")]
    [XmlElement("matlinkprocessed")]
    [Browsable(false)]
    public string MaterialLinkProcessedString
    {
        get => MaterialLinkProcessed.ToString();
        set => MaterialLinkProcessed = bool.Parse(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public bool MaterialLinkProcessed { get; set; }

    [JsonPropertyName("quantity")]
    [XmlElement("quantity")]
    public double Quantity { get; set; }
    
    [JsonPropertyName("purchaseorderisordered")]
    [XmlElement("purchaseorderisordered")]
    [Browsable(false)]
    public string PurchaseOrderIsOrderedString
    {
        get => PurchaseOrderIsOrdered.ToString();
        set => PurchaseOrderIsOrdered = bool.Parse(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public bool PurchaseOrderIsOrdered { get; set; }

    [JsonPropertyName("deleted")]
    [XmlElement("deleted")]
    [Browsable(false)]
    public string DeletedString
    {
        get => Deleted.ToString();
        set => Deleted = bool.Parse(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public bool Deleted { get; set; }

    [JsonPropertyName("takenfrom")]
    [XmlElement("takenfrom")]
    public TakenFrom TakenFrom { get; set; }

    [JsonPropertyName("item")]
    [XmlElement("item")]
    public string Item { get; set; }

    [JsonPropertyName("cost")]
    [XmlElement("cost")]
    public double Cost { get; set; }

    [JsonPropertyName("deleteddate")]
    [XmlElement("deleteddate")]
    [Browsable(false)]
    public string DeletedDateString
    {
        get => DeletedDate?.ToString(Constants.DATE_FORMAT);
        set => DeletedDate = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? DeletedDate { get; set; }

    [JsonPropertyName("sell")]
    [XmlElement("sell")]
    public double Sell { get; set; }

    [JsonPropertyName("lineid")]
    [XmlElement("lineid")]
    public string LineId { get; set; }

    [JsonPropertyName("purchaseorderqtybilled")]
    [XmlElement("purchaseorderqtybilled")]
    public string PurchaseOrderQtyBilled { get; set; } // TODO: bool?

    [JsonPropertyName("partnumber")]
    [XmlElement("partnumber")]
    public string PartNumber { get; set; }

    [JsonPropertyName("purchaseorderqtyordered")]
    [XmlElement("purchaseorderqtyordered")]
    public string PurchaseOrderQtyOrdered { get; set; } // TODO: double?

    // deletedtime

    // dateused

    // itemid

    // isinventory /bool

    // deleteddatetime
}

public class TakenFrom
{
    [JsonPropertyName("takenfromid")]
    [XmlElement("takenfromid")]
    public string TakenFromId { get; set; }

    [JsonPropertyName("takenfromtype")]
    [XmlElement("takenfromtype")]
    public string TakenFromType { get; set; }

    [JsonPropertyName("takenfromname")]
    [XmlElement("takenfromname")]
    public string TakenFromName { get; set; }
}
