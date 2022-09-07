using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Helpers;

namespace AroFloSharp.Serialization.Models;

public class Quote : AroFloObjectBase
{
    [JsonPropertyName("totalinc")]
    [XmlElement("totalinc")]
    public double TotalIncluded { get; set; }

    [JsonPropertyName("totaltax")]
    [XmlElement("totaltax")]
    public double TotalTax { get; set; }

    [JsonPropertyName("totalex")]
    [XmlElement("totalex")]
    public double TotalExcluded { get; set; }

    [JsonPropertyName("estimator")]
    [XmlElement("estimator")]
    public Estimator Estimator { get; set; }

    [JsonPropertyName("approveddate")]
    [XmlElement("approveddate")]
    public string ApprovedDateString
    {
        get => ApprovedDate?.ToString(Constants.DATE_FORMAT);
        set => ApprovedDate = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? ApprovedDate { get; set; }

    [JsonPropertyName("lines")]
    [XmlArrayItem("line")]
    [XmlArray("lines")]
    public List<LineItem> Lines { get; set; }

    [JsonPropertyName("totalhours")]
    [XmlElement("totalhours")]
    public double TotalHours { get; set; }

    [JsonPropertyName("quoteid")]
    [XmlElement("quoteid")]
    public string QuoteId { get; set; }

    [JsonPropertyName("status")]
    [XmlElement("status")]
    public string Status { get; set; }

    [JsonPropertyName("documentsandphotos")]
    [XmlArrayItem("documentandphoto")]
    [XmlArray("documentsandphotos")]
    public List<DocumentAndPhoto> DocumentsAndPhotos { get; set; }

    [JsonPropertyName("totalprofitmarginpercent")]
    [XmlElement("totalprofitmarginpercent")]
    public double TotalProfitMarginPercent { get; set; }



    [JsonPropertyName("acceptanceexpirydate")]
    [XmlElement("acceptanceexpirydate")]
    public string AcceptanceExpiryDateString
    {
        get => AcceptanceExpiryDate?.ToString(Constants.DATE_FORMAT);
        set => AcceptanceExpiryDate = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? AcceptanceExpiryDate { get; set; }

    [JsonPropertyName("type")]
    [XmlElement("type")]
    public string Type { get; set; }

    [JsonPropertyName("duedate")]
    [XmlElement("duedate")]
    public string DueDateString
    {
        get => DueDate?.ToString(Constants.DATE_FORMAT);
        set => DueDate = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? DueDate { get; set; }

    [JsonPropertyName("approveddatetime")]
    [XmlElement("approveddatetime")]
    public string ApprovedDateTimeString
    {
        get => ApprovedDateTime?.ToString(Constants.DATE_TIME_FORMAT);
        set => ApprovedDateTime = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? ApprovedDateTime { get; set; }

    [JsonPropertyName("rejecteddatetime")]
    [XmlElement("rejecteddatetime")]
    public string RejectedDateTimeString
    {
        get => RejectedDateTime?.ToString(Constants.DATE_TIME_FORMAT);
        set => RejectedDateTime = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? RejectedDateTime { get; set; }

    [JsonPropertyName("task")]
    [XmlElement("task")]
    public Task Task { get; set; }

    [JsonPropertyName("project")]
    [XmlElement("project")]
    public Project Project { get; set; }

    [JsonPropertyName("jobnumber")]
    [XmlElement("jobnumber")]
    public string JobNumber { get; set; }

    [JsonPropertyName("labourcostex")]
    [XmlElement("labourcostex")]
    public double LabourCostEx { get; set; }

    [JsonPropertyName("totalprofit")]
    [XmlElement("totalprofit")]
    public double TotalProfit { get; set; }

    [JsonPropertyName("createddatetime")]
    [XmlElement("createddatetime")]
    public string CreatedDateTimeString
    {
        get => CreatedDateTime?.ToString(Constants.DATE_TIME_FORMAT);
        set => CreatedDateTime = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? CreatedDateTime { get; set; }

    [JsonPropertyName("acceptancestatus")]
    [XmlElement("acceptancestatus")]
    public string AcceptanceStatus { get; set; } // TODO bool?

    [JsonPropertyName("address")]
    [XmlElement("address")]
    public Address Address { get; set; }

    // exclusions

    [JsonPropertyName("acceptancedate")]
    [XmlElement("acceptancedate")]
    public string AcceptanceDateString
    {
        get => AcceptanceDate?.ToString(Constants.DATE_FORMAT);
        set => AcceptanceDate = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? AcceptanceDate { get; set; }

    [JsonPropertyName("substatus")]
    [XmlElement("substatus")]
    public SubStatus SubStatus { get; set; }

    [JsonPropertyName("contactname")]
    [XmlElement("contactname")]
    public string ContactName { get; set; }

    [JsonPropertyName("org")]
    [XmlElement("org")]
    public Organization Organization { get; set; }

    [JsonPropertyName("overallmarkuppercent")]
    [XmlElement("overallmarkuppercent")]
    public double OverallMarkupPercent { get; set; }


    [JsonPropertyName("createddate")]
    [XmlElement("createddate")]
    public string CreatedDateString
    {
        get => CreatedDate?.ToString(Constants.DATE_FORMAT);
        set => CreatedDate = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? CreatedDate { get; set; }

    [JsonPropertyName("notes")]
    [XmlArrayItem("note")]
    [XmlArray("notes")]
    public List<Note> Notes { get; set; }
    
    [JsonPropertyName("subtotal")]
    [XmlElement("subtotal")]
    public double SubTotal { get; set; }

    [JsonPropertyName("description")]
    [XmlElement("description")]
    public string Description { get; set; }

    [JsonPropertyName("refno")]
    [XmlElement("refno")]
    public string ReferenceNumber { get; set; }

    [JsonPropertyName("quotename")]
    [XmlElement("quotename")]
    public string QuoteName { get; set; }

    [JsonPropertyName("custon")]
    [XmlElement("custon")]
    public string CustomerOrderNumber { get; set; }

    [JsonPropertyName("acceptanceexpirydatetime")]
    [XmlElement("acceptanceexpirydatetime")]
    public string AcceptanceExpiryDateTimeString
    {
        get => AcceptanceExpiryDateTime?.ToString(Constants.DATE_TIME_FORMAT);
        set => AcceptanceExpiryDateTime = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? AcceptanceExpiryDateTime { get; set; }

    [JsonPropertyName("rejecteddate")]
    [XmlElement("rejecteddate")]
    public string RejectedDateString
    {
        get => RejectedDate?.ToString(Constants.DATE_FORMAT);
        set => RejectedDate = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? RejectedDate { get; set; }

    [JsonPropertyName("stage")]
    [XmlElement("stage")]
    public Stage Stage { get; set; }

    [JsonPropertyName("taskdescription")]
    [XmlElement("taskdescription")]
    public string TaskDescription { get; set; }

    [JsonPropertyName("materialcostex")]
    [XmlElement("materialcostex")]
    public double MaterialCostEx { get; set; }

    [JsonPropertyName("duedatetime")]
    [XmlElement("duedatetime")]
    public string DueDateTimeString
    {
        get => DueDateTime?.ToString(Constants.DATE_TIME_FORMAT);
        set => DueDateTime = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? DueDateTime { get; set; }

    [JsonPropertyName("client")]
    [XmlElement("client")]
    public Client Client { get; set; }

    [JsonPropertyName("acceptedby")]
    [XmlElement("acceptedby")]
    public Contact AcceptedBy { get; set; }

    [JsonPropertyName("istaxinclusive")]
    [XmlElement("istaxinclusive")]
    public bool IsTaxInclusive { get; set; }

    [JsonPropertyName("acceptancedatetime")]
    [XmlElement("acceptancedatetime")]
    public string AcceptanceDateTimeString
    {
        get => AcceptanceDateTime?.ToString(Constants.DATE_TIME_FORMAT);
        set => AcceptanceDateTime = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? AcceptanceDateTime { get; set; }

    [JsonPropertyName("allowancecostex")]
    [XmlElement("allowancecostex")]
    public double AllowanceCostEx { get; set; }

    [JsonPropertyName("contactphone")]
    [XmlElement("contactphone")]
    public string ContactPhone { get; set; }
}

public class Estimator : Person { }