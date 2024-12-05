using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Helpers;

namespace AroFloSharp.Serialization.Models;

public class Timesheet
{
    [JsonPropertyName("verifiedby")]
    [XmlElement("verifiedby")]
    public VerifiedBy VerifiedBy { get; set; }

    [JsonPropertyName("task")]
    [XmlElement("task")]
    public TimesheetTask Task { get; set; }

    [JsonPropertyName("worktype")]
    [XmlElement("worktype")]
    public TimesheetWorkType WorkType { get; set; }

    [JsonPropertyName("trackingcentre")]
    [XmlElement("trackingcentre")]
    public TimesheetTrackingCentre TrackingCentre { get; set; }

    [JsonPropertyName("insertedby")]
    [XmlElement("insertedby")]
    public Person InsertedBy { get; set; }

    [JsonPropertyName("chargerate")]
    [XmlElement("chargerate")]
    public double ChargeRate { get; set; }

    [JsonPropertyName("user")]
    [XmlElement("user")]
    public Person User { get; set; }

    [JsonPropertyName("overhead")]
    [XmlElement("overhead")]
    public TimesheetOverhead Overhead { get; set; }

    [JsonPropertyName("costrate")]
    [XmlElement("costrate")]
    public double CostRate { get; set; }

    [JsonPropertyName("inserteddatetimeutc")]
    [XmlElement("inserteddatetimeutc")]
    [Obsolete("Used by serializer to format. Use InsertedDateTimeUtc", false)]
    public string InsertedDateTimeUtcString
    {
        get => InsertedDateTimeUtc?.ToString(Constants.DATE_TIME_FORMAT);
        set => InsertedDateTimeUtc = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? InsertedDateTimeUtc { get; set; }

    [JsonPropertyName("cost")]
    [XmlElement("cost")]
    public double Cost { get; set; }

    [JsonPropertyName("hours")]
    [XmlElement("hours")]
    public double Hours { get; set; }
     
    [JsonPropertyName("hourlyrate")]
    [XmlElement("hourlyrate")]
    public double HourlyRate { get; set; }

    [JsonPropertyName("note")]
    [XmlElement("note")]
    public string Note { get; set; }

    [JsonPropertyName("grouping")]
    [XmlElement("grouping")]
    public TimesheetGrouping Grouping { get; set; }

    [JsonPropertyName("finishdatetime")]
    [XmlElement("finishdatetime")]
    [Obsolete("Used by serializer to format. Use FinishDateTime", false)]
    public string FinishDateTimeString
    {
        get => FinishDateTime?.ToString(Constants.DATE_TIME_FORMAT);
        set => FinishDateTime = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? FinishDateTime { get; set; }

    [JsonPropertyName("timesheetid")]
    [XmlElement("timesheetid")]
    public string TimesheetId { get; set; }

    [JsonPropertyName("startdatetime")]
    [XmlElement("startdatetime")]
    [Obsolete("Used by serializer to format. Use StartDateTime", false)]
    public string StartDateTimeString
    {
        get => StartDateTime?.ToString(Constants.DATE_TIME_FORMAT);
        set => StartDateTime = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? StartDateTime { get; set; }

    [JsonPropertyName("type")]
    [XmlElement("type")]
    public string Type { get; set; }

    [JsonPropertyName("charge")]
    [XmlElement("charge")]
    public double Charge { get; set; }

    [JsonPropertyName("workdate")]
    [XmlElement("workdate")]
    [Obsolete("Used by serializer to format. Use WorkDate", false)]
    public string WorkDateString
    {
        get => WorkDate?.ToString(Constants.DATE_FORMAT);
        set => WorkDate = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? WorkDate { get; set; }

    [JsonPropertyName("resourceoverheadrate")]
    [XmlElement("resourceoverheadrate")]
    public double ResourceOverheadRate { get; set; }
}

public class VerifiedBy
{
    [JsonPropertyName("surname")]
    [XmlElement("surname")]
    public string Surname { get; set; }

    [JsonPropertyName("givennames")]
    [XmlElement("givennames")]
    public string GivenNames { get; set; }

    [JsonPropertyName("isverified")]
    [XmlElement("isverified")]
    [Obsolete("Used by serializer to format. Use IsVerified", false)]
    public string IsVerifiedString
    {
        get => IsVerified.ToString();
        set => IsVerified = bool.Parse(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public bool IsVerified { get; set; }

    [JsonPropertyName("userid")]
    [XmlElement("userid")]
    public string UserId { get; set; }

    [JsonPropertyName("verifieddatetime")]
    [XmlElement("verifieddatetime")]
    [Obsolete("Used by serializer to format. Use VertifiedDateTime", false)]
    public string VerifiedDateTimeString
    {
        get => VerifiedDateTime?.ToString(Constants.DATE_TIME_FORMAT);
        set => VerifiedDateTime = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? VerifiedDateTime { get; set; }
}

public class TimesheetTask
{
    [JsonPropertyName("taskid")]
    [XmlElement("taskid")]
    public string TaskId { get; set; }

    [JsonPropertyName("jobnumber")]
    [XmlElement("jobnumber")]
    public string JobNumber { get; set; }

    [JsonPropertyName("taskname")]
    [XmlElement("taskname")]
    public string TaskName { get; set; }
}

public class TimesheetWorkType
{
    [JsonPropertyName("worktyperatetype")]
    [XmlElement("worktyperatetype")]
    public string WorkTypeRateType { get; set; }

    [JsonPropertyName("worktype")]
    [XmlElement("worktype")]
    public string WorkTypeText { get; set; }

    [JsonPropertyName("worktypedescription")]
    [XmlElement("worktypedescription")]
    public string WorkTypeDescription { get; set; }

    [JsonPropertyName("worktypeid")]
    [XmlElement("worktypeid")]
    public string WorkTypeId { get; set; }
}

public class TimesheetTrackingCentre
{
    [JsonPropertyName("trackingcentre")]
    [XmlElement("trackingcentre")]
    public string TrackingCentreText { get; set; }

    [JsonPropertyName("trackingcentreid")]
    [XmlElement("trackingcentreid")]
    public string TrackingCentreId { get; set; }
}
public class TimesheetOverhead
{
    [JsonPropertyName("overheadid")]
    [XmlElement("overheadid")]
    public string OverheadId { get; set; }

    [JsonPropertyName("overheadunit")]
    [XmlElement("overheadunit")]
    public string OverheadUnit { get; set; }

    [JsonPropertyName("overhead")]
    [XmlElement("overhead")]
    public string OverheadText { get; set; }

    [JsonPropertyName("overheadtype")]
    [XmlElement("overheadtype")]
    public string OverheadType { get; set; }
}
public class TimesheetGrouping
{
    [JsonPropertyName("groupid")]
    [XmlElement("groupid")]
    public string GroupId { get; set; }

    [JsonPropertyName("tsgroupid")]
    [XmlElement("tsgroupid")]
    public string TsGroupId { get; set; }
}
