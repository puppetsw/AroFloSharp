using System;
using System.ComponentModel;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Helpers;

namespace AroFloSharp.Serialization.Models;

public class TaskProject
{
    [JsonPropertyName("location")]
    [XmlElement("location")]
    public TaskLocation Location { get; set; }

    [JsonPropertyName("contact")]
    [XmlElement("contact")]
    public string Contact { get; set; }

    [JsonPropertyName("startdate")]
    [XmlElement("startdate")]
    [Browsable(false)]
    public string StartDateString
    {
        get => StartDate?.ToString(Constants.DATE_FORMAT);
        set => StartDate = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? StartDate { get; set; }

    [JsonPropertyName("projecttype")]
    [XmlElement("projecttype")]
    public string ProjectType { get; set; }

    [JsonPropertyName("enddate")]
    [XmlElement("enddate")]
    [Browsable(false)]
    public string EndDateString
    {
        get => EndDate?.ToString(Constants.DATE_FORMAT);
        set => EndDate = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? EndDate { get; set; }

    [JsonPropertyName("status")]
    [XmlElement("status")]
    public string Status { get; set; }

    [JsonPropertyName("closeddate")]
    [XmlElement("closeddate")]
    [Browsable(false)]
    public string ClosedDateString
    {
        get => ClosedDate?.ToString(Constants.DATE_FORMAT);
        set => ClosedDate = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? ClosedDate { get; set; }

    [JsonPropertyName("description")]
    [XmlElement("description")]
    public string Description { get; set; }

    [JsonPropertyName("projectid")]
    [XmlElement("projectid")]
    public string ProjectId { get; set; }

    [JsonPropertyName("refno")]
    [XmlElement("refno")]
    public string ReferenceNumber { get; set; }

    [JsonPropertyName("manager")]
    [XmlElement("manager")]
    public string Manager { get; set; }

    [JsonPropertyName("custon")]
    [XmlElement("custon")]
    public string CustomerOrderNumber { get; set; }

    [JsonPropertyName("projectnumber")]
    [XmlElement("projectnumber")]
    public string ProjectNumber { get; set; }

    [JsonPropertyName("projectname")]
    [XmlElement("projectname")]
    public string ProjectName { get; set; }
}
