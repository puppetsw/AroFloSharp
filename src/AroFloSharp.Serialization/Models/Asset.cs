using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace AroFloSharp.Serialization.Models;

public class Asset : AroFloObjectBase
{
    [JsonPropertyName("assetid")]
    [XmlElement("assetid")]
    public string AssetId { get; set; }

    [JsonPropertyName("odotype")]
    [XmlElement("odotype")]
    public string OdoType { get; set; }

    [JsonPropertyName("modelnumber")]
    [XmlElement("modelnumber")]
    public string ModelNumber { get; set; }

    [JsonPropertyName("serialnumber")]
    [XmlElement("serialnumber")]
    public string SerialNumber { get; set; }

    [JsonPropertyName("quantity")]
    [XmlElement("quantity")]
    public int Quantity { get; set; }

    [JsonPropertyName("barcode")]
    [XmlElement("barcode")]
    public string Barcode { get; set; }

    [JsonPropertyName("manufacturer")]
    [XmlElement("manufacturer")]
    public string Manufacturer { get; set; }

    [JsonPropertyName("supplier")]
    [XmlElement("supplier")]
    public string Supplier { get; set; }

    [JsonPropertyName("assetname")]
    [XmlElement("assetname")]
    public string AssetName { get; set; }

    [JsonPropertyName("cost")]
    [XmlElement("cost")]
    public double Cost { get; set; }

    [JsonPropertyName("customerid")]
    [XmlElement("customerid")]
    public string CustomerId { get; set; }

    [JsonPropertyName("odo")]
    [XmlElement("odo")]
    public string Odo { get; set; }

    [JsonPropertyName("ordercode")]
    [XmlElement("ordercode")]
    public string OrderCode { get; set; }

}
