using System;
using System.ComponentModel;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Helpers;

namespace AroFloSharp.Serialization.Models;

public class Labour : AroFloObjectBase
{
    [JsonPropertyName("labverified")]
    [XmlElement("labverified")]
    [Browsable(false)]
    public string LabourVerifiedString
    {
        get => LabourVerified.ToString();
        set => LabourVerified = bool.Parse(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public bool LabourVerified { get; set; }

    [JsonPropertyName("worktype")]
    [XmlElement("worktype")]
    public string WorkType { get; set; }

    [JsonPropertyName("workdatetimeend")]
    [XmlElement("workdatetimeend")]
    [Browsable(false)]
    public string WorkDateTimeEndString
    {
        get => WorkDateTimeEnd?.ToString(Constants.DATE_TIME_FORMAT);
        set => WorkDateTimeEnd = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? WorkDateTimeEnd { get; set; }

    [JsonPropertyName("lablinkprocesseddatetime")]
    [XmlElement("lablinkprocesseddatetime")]
    [Browsable(false)]
    public string LabourLinkProcessedDateTimeString
    {
        get => LabourLinkProcessedDateTime?.ToString(Constants.DATE_FORMAT);
        set => LabourLinkProcessedDateTime = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? LabourLinkProcessedDateTime { get; set; }

    [JsonPropertyName("lablinkprocesseddate")]
    [XmlElement("lablinkprocesseddate")]
    [Browsable(false)]
    public string LabourLinkProcessedDateString
    {
        get => LabourLinkProcessedDate?.ToString(Constants.DATE_FORMAT);
        set => LabourLinkProcessedDate = DateTimeHelpers.TrySetDate(value);
    }

    public DateTime? LabourLinkProcessedDate { get; set; }

    [JsonPropertyName("endtime")]
    [XmlElement("endtime")]
    [Browsable(false)]
    public string EndTimeString
    {
        get => EndTime?.ToString(Constants.TIME_FORMAT);
        set => EndTime = DateTimeHelpers.TrySetDate(value);
    }

    public DateTime? EndTime { get; set; }

    [JsonPropertyName("deleted")]
    [XmlElement("deleted")]
    public int Deleted { get; set; }

    [JsonPropertyName("user")]
    [XmlElement("user")]
    public User User { get; set; }

    [JsonPropertyName("lablinkprocessed")]
    [XmlElement("lablinkprocessed")]
    [Browsable(false)]
    public string LabourLinkProcessedString
    {
        get => LabourLinkProcessed.ToString();
        set => LabourLinkProcessed = bool.Parse(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public bool LabourLinkProcessed { get; set; }


    [JsonPropertyName("cost")]
    [XmlElement("cost")]
    public double Cost { get; set; }

    [JsonPropertyName("starttime")]
    [XmlElement("starttime")]
    [Browsable(false)]
    public string StartTimeString
    {
        get => StarTime?.ToString(Constants.TIME_FORMAT);
        set => StarTime = DateTimeHelpers.TrySetDate(value);
    }

    public DateTime? StarTime { get; set; }

    [JsonPropertyName("deleteddate")]
    [XmlElement("deleteddate")]
    // TODO: Change to DateTime when we know the format?
    public string DeletedDate { get; set; }

    [JsonPropertyName("hours")]
    [XmlElement("hours")]
    public double Hours { get; set; }

    [JsonPropertyName("sell")]
    [XmlElement("sell")]
    public double Sell { get; set; }

    [JsonPropertyName("lineid")]
    [XmlElement("lineid")]
    public string LineId { get; set; }

    [JsonPropertyName("workdatetimestart")]
    [XmlElement("workdatetimestart")]
    [Browsable(false)]
    public string WorkDateTimeStartString
    {
        get => WorkDateTimeStart?.ToString(Constants.DATE_FORMAT);
        set => WorkDateTimeStart = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? WorkDateTimeStart { get; set; }

    [JsonPropertyName("note")]
    [XmlElement("note")]
    public string Note { get; set; }

    [JsonPropertyName("lablocked")]
    [XmlElement("lablocked")]
    [Browsable(false)]
    public string LabourLockedString
    {
        get => LabourLocked.ToString();
        set => LabourLocked = bool.Parse(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public bool LabourLocked { get; set; }

    [JsonPropertyName("deletedtime")]
    [XmlElement("deletedtime")]
    public string DeletedTime { get; set; }

    [JsonPropertyName("deleteddatetime")]
    [XmlElement("deleteddatetime")]
    public string DeletedDateTime { get; set; }

    [JsonPropertyName("workdate")]
    [XmlElement("workdate")]
    [Browsable(false)]
    public string WorkDateString
    {
        get => WorkDateStart?.ToString(Constants.DATE_FORMAT);
        set => WorkDateStart = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? WorkDateStart { get; set; }

}
