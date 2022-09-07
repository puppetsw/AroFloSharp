using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace AroFloSharp.Serialization.Models;

public class LineItem : AroFloObjectBase
{
    [JsonPropertyName("worktypevalue")]
    [XmlElement("worktypevalue")]
    public double WorkTypeValue { get; set; }

    [JsonPropertyName("worktype")]
    [XmlElement("worktype")]
    public string WorkType { get; set; }

    [JsonPropertyName("totalinc")]
    [XmlElement("totalinc")]
    public double TotalIncluded { get; set; }

    [JsonPropertyName("optiongroupname")]
    [XmlElement("optiongroupname")]
    public string OptionGroupName { get; set; }

    [JsonPropertyName("itemtype")]
    [XmlElement("itemtype")]
    public string ItemType { get; set; }

    [JsonPropertyName("partno")]
    [XmlElement("partno")]
    public string PartNo { get; set; }

    [JsonPropertyName("isapproved")]
    [XmlElement("isapproved")]
    public bool IsApproved { get; set; }

    [JsonPropertyName("totalex")]
    [XmlElement("totalex")]
    public double TotalExcluded { get; set; }

    [JsonPropertyName("labourunitrate")]
    [XmlElement("labourunitrate")]
    public double LabourUnitRate { get; set; }

    [JsonPropertyName("item")]
    [XmlElement("item")]
    public string Item { get; set; }

    [JsonPropertyName("cost")]
    [XmlElement("cost")]
    public double Cost { get; set; }

    [JsonPropertyName("parentlineid")]
    [XmlElement("parentlineid")]
    public string ParentLineId { get; set; }

    [JsonPropertyName("sell")]
    [XmlElement("sell")]
    public double Sell { get; set; }

    [JsonPropertyName("labourtotal")]
    [XmlElement("labourtotal")]
    public double LabourTotal { get; set; }

    [JsonPropertyName("lineid")]
    [XmlElement("lineid")]
    public string LineId { get; set; }

    [JsonPropertyName("taxcode")]
    [XmlElement("taxcode")]
    public string TaxCode { get; set; }

    [JsonPropertyName("qty")]
    [XmlElement("qty")]
    public double Quantity { get; set; }

    [JsonPropertyName("markup")]
    [XmlElement("markup")]
    public double Markup { get; set; }

    [JsonPropertyName("labourmarkup")]
    [XmlElement("labourmarkup")]
    public double LabourMarkup { get; set; }

    [JsonPropertyName("totaltax")]
    [XmlElement("totaltax")]
    public double TotalTax { get; set; }

    [JsonPropertyName("isoptional")]
    [XmlElement("isoptional")]
    public bool IsOptional { get; set; }

    [JsonPropertyName("itemid")]
    [XmlElement("itemid")]
    public string ItemId { get; set; }

    [JsonPropertyName("takeoffname")]
    [XmlElement("takeoffname")]
    public string TakeOffName { get; set; }

    [JsonPropertyName("taxrate")]
    [XmlElement("taxrate")]
    public double TaxRate { get; set; }
}
