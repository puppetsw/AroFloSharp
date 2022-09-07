using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Helpers;

namespace AroFloSharp.Serialization.Models;

public class Task
{
    [JsonPropertyName("contact")]
    [XmlElement("contact")]
    public Person Contact { get; set; }

    [JsonPropertyName("completeddatetime")]
    [XmlElement("completeddatetime")]
    [Browsable(false)]
    public string CompletedDateTimeString
    {
        get => CompleteDateTime?.ToString("yyyy-MM-dd HH:mm:ss");
        set => CompleteDateTime = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? CompleteDateTime { get; set; }

    [JsonPropertyName("priority")]
    [XmlElement("priority")]
    public string Priority { get; set; }

    [JsonPropertyName("tasknotes")]
    [XmlElement("tasknotes")]
    public string[] TaskNotes { get; set; }

    [JsonPropertyName("gpslongitude")]
    [XmlElement("gpslongitude")]
    public string GpsLongitude { get; set; }

    [JsonPropertyName("requestdatetime")]
    [XmlElement("requestdatetime")]
    [Browsable(false)]
    public string RequestDateTimeString
    {
        get => RequestDateTime?.ToString("yyyy-MM-dd HH:mm:ss");
        set => RequestDateTime = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? RequestDateTime { get; set; }

    [JsonPropertyName("lastupdatedutc")]
    [XmlElement("lastupdatedutc")]
    [Browsable(false)]
    public string LastUpdatedUtcString
    {
        get => LastUpdatedUtc?.ToString("yyyy-MM-dd HH:mm:ss");
        set => LastUpdatedUtc = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? LastUpdatedUtc { get; set; }

    [JsonPropertyName("status")]
    [XmlElement("status")]
    public string Completed { get; set; }

    [JsonPropertyName("gpslatitude")]
    [XmlElement("gpslatitude")]
    public string GpsLatitude { get; set; }

    [JsonPropertyName("tasklocation")]
    [XmlElement("tasklocation")]
    public TaskLocation TaskLocation { get; set; }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? LinkProcessedDate { get; set; }

    [JsonPropertyName("linkprocesseddate")]
    [XmlElement("linkprocesseddate")]
    [Browsable(false)]
    public string LinkProcessedDateString
    {
        get => LinkProcessedDate?.ToString("yyyy-MM-dd HH:mm:ss");
        set => LinkProcessedDate = DateTimeHelpers.TrySetDate(value);
    }

    [JsonPropertyName("refcode")]
    [XmlElement("refcode")]
    public string RefCode { get; set; }

    /// <summary>
    /// Requires join.
    /// </summary>
    [JsonPropertyName("documentsandphotos")]
    [XmlArrayItem("documentsandphoto")]
    [XmlArray("documentsandphotos")]
    public List<DocumentAndPhoto> DocumentAndPhotos { get; set; }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? DueDate { get; set; }

    [JsonPropertyName("duedate")]
    [XmlElement("duedate")]
    [Browsable(false)]
    public string DueDateString
    {
        get => DueDate?.ToString("yyyy-MM-dd");
        set => DueDate = DateTimeHelpers.TrySetDate(value);
    }

    /// <summary>
    /// Requires join
    /// </summary>
    [JsonPropertyName("labours")]
    [XmlArrayItem("labour")]
    [XmlArray("labours")]
    public List<Labour> Labours { get; set; }

    [JsonPropertyName("assets")]
    [XmlArrayItem("asset")]
    [XmlArray("assets")]
    public List<Asset> Assets { get; set; }

    [JsonPropertyName("assetid")]
    [XmlElement("assetid")]
    public string AssetId { get; set; }

    [JsonPropertyName("project")]
    [XmlElement("project")]
    public TaskProject Project { get; set; }

    /// <summary>
    /// SalesPerson requires join.
    /// </summary>
    [JsonPropertyName("salesperson")]
    [XmlArrayItem("salesperson")]
    [XmlArray("salesperson")]
    public List<SalesPerson> SalesPerson { get; set; }

    [JsonPropertyName("jobnumber")]
    [XmlElement("jobnumber")]
    public string JobNumber { get; set; }

    [JsonPropertyName("taskname")]
    [XmlElement("taskname")]
    public string TaskName { get; set; }

    /// <summary>
    /// TaskTotals requires join.
    /// </summary>
    [JsonPropertyName("tasktotals")]
    [XmlElement("tasktotals")]
    public TaskTotals TaskTotals { get; set; }

    /// <summary>
    /// PurchaseOrders requires join.
    /// </summary>
    [JsonPropertyName("purchaseorders")]
    [XmlArrayItem("purchaseorderid")]
    [XmlArray("purchaseorders")]
    public List<string> PurchaseOrders { get; set; }

    /// <summary>
    /// Requires join.
    /// </summary>
    [JsonPropertyName("materials")]
    [XmlArrayItem("material")]
    [XmlArray("materials")]
    public List<Material> Materials { get; set; }

    /// <summary>
    /// Requires join.
    /// </summary>
    [JsonPropertyName("substatus")]
    [XmlElement("substatus")]
    public SubStatus SubStatus { get; set; }

    [JsonPropertyName("tasktasktype")]
    [XmlElement("tasktasktype")]
    public TaskTaskType TaskTaskType { get; set; }

    /// <summary>
    /// Location requires join.
    /// </summary>
    [JsonPropertyName("location")]
    [XmlElement("location")]
    public Location Location { get; set; }

    /// <summary>
    /// Requires join.
    /// </summary>
    [JsonPropertyName("quote")]
    [XmlElement("quote")]
    public Quote Quote { get; set; }

    [JsonPropertyName("contactname")]
    [XmlElement("contactname")]
    public string ContactName { get; set; }

    [JsonPropertyName("org")]
    [XmlElement("org")]
    public Organization Organization { get; set; }

    /// <summary>
    /// Requires join.
    /// </summary>
    [JsonPropertyName("expenses")]
    [XmlArrayItem("expense")]
    [XmlArray("expenses")]
    public List<Expense> Expenses { get; set; }

    [JsonPropertyName("readtaskdatetime")]
    [XmlElement("readtaskdatetime")]
    [Browsable(false)]
    public string ReadTaskDateTimeString
    {
        get => ReadTaskDateTime?.ToString(Constants.DATE_TIME_FORMAT);
        set => ReadTaskDateTime = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? ReadTaskDateTime { get; set; }

    [JsonPropertyName("description")]
    [XmlElement("description")]
    public string Description { get; set; }

    [JsonPropertyName("completeddate")]
    [XmlElement("completeddate")]
    [Browsable(false)]
    public string CompletedDateString
    {
        get => CompletedDate?.ToString(Constants.DATE_FORMAT);
        set => CompletedDate = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? CompletedDate { get; set; }

    [JsonPropertyName("custon")]
    [XmlElement("custon")]
    public string CustomerOrderNumber { get; set; }

    /// <summary>
    /// Requires join
    /// </summary>
    [JsonPropertyName("assigneds")]
    [XmlArrayItem("assigned")]
    [XmlArray("assigneds")]
    public List<TaskAssignedHistory> AssignedHistory { get; set; }

    [JsonPropertyName("readtask")]
    [XmlElement("readtask")]
    public string ReadTaskString
    {
        get => ReadTask.ToString();
        set => ReadTask = bool.Parse(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public bool ReadTask { get; set; }

    [JsonPropertyName("stage")]
    [XmlElement("stage")]
    public TaskStage Stage { get; set; }

    [JsonPropertyName("duedatetime")]
    [XmlElement("duedatetime")]
    [Browsable(false)]
    public string DueDateTimeString
    {
        get => DueDateTime?.ToString(Constants.DATE_TIME_FORMAT);
        set => DueDateTime = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? DueDateTime { get; set; }

    [JsonPropertyName("linkprocessed")]
    [XmlElement("linkprocessed")]
    public string LinkProcessedString
    {
        get => LinkProcessed.ToString();
        set => LinkProcessed = bool.Parse(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public bool LinkProcessed { get; set; }

    /// <summary>
    /// Requires join
    /// </summary>
    [JsonPropertyName("customfields")]
    [XmlArrayItem("customfield")]
    [XmlArray("customfields")]
    public List<CustomField> CustomFields { get; set; }

    [JsonPropertyName("client")]
    [XmlElement("client")]
    public SmallClient Client { get; set; }

    [JsonPropertyName("taskid")]
    [XmlElement("taskid")]
    public string TaskId { get; set; }

    [JsonPropertyName("lastupdateddatetimeutc")]
    [XmlElement("lastupdateddatetimeutc")]
    [Browsable(false)]
    public string LastUpdateDateTimeUtcString
    {
        get => LastUpdateDateTimeUtc?.ToString(Constants.DATE_TIME_FORMAT);
        set => LastUpdateDateTimeUtc = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? LastUpdateDateTimeUtc { get; set; }

    [JsonPropertyName("requestdate")]
    [XmlElement("requestdate")]
    [Browsable(false)]
    public string RequestDateString
    {
        get => RequestDate?.ToString(Constants.DATE_FORMAT);
        set => RequestDate = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? RequestDate { get; set; }

    [JsonPropertyName("contactphone")]
    [XmlElement("contactphone")]
    public string ContactPhone { get; set; }

    [JsonPropertyName("tasktype")]
    [XmlElement("tasktype")]
    public string TaskType { get; set; }

    // webappencodedid?
}

public class SubStatus
{
    [JsonPropertyName("substatusid")]
    [XmlElement("substatusid")]
    public string SubStatusId { get; set; }

    [JsonPropertyName("substatus")]
    [XmlElement("substatus")]
    public string SubStatusText { get; set; }
}

public class TaskTaskType
{
    [JsonPropertyName("tasktypeid")]
    [XmlElement("tasktypeid")]
    public string TaskTypeId { get; set; }

    [JsonPropertyName("tasktype")]
    [XmlElement("tasktype")]
    public string TaskTypeText { get; set; }
}

public class TaskAssignedHistory
{
    [JsonPropertyName("readtaskdatetime")]
    [XmlElement("readtaskdatetime")]
    [Browsable(false)]
    public string ReadTaskDateTimeString
    {
        get => ReadTaskDateTime?.ToString(Constants.DATE_TIME_FORMAT);
        set => ReadTaskDateTime = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? ReadTaskDateTime { get; set; }

    [JsonPropertyName("readtask")]
    [XmlElement("readtask")]
    [Browsable(false)]
    public string ReadTaskString
    {
        get => ReadTask.ToString();
        set => ReadTask = bool.Parse(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public bool ReadTask { get; set; }

    [JsonPropertyName("org")]
    [XmlElement("org")]
    public Organization Organization { get; set; }

    [JsonPropertyName("dateunassigned")]
    [XmlElement("dateunassigned")]
    [Browsable(false)]
    public string DateUnassignedString
    {
        get => DateUnassigned?.ToString(Constants.DATE_FORMAT);
        set => DateUnassigned = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? DateUnassigned { get; set; }

    [JsonPropertyName("timeunassigned")]
    [XmlElement("timeunassigned")]
    [Browsable(false)]
    public string TimeUnassignedString
    {
        get => TimeUnassigned?.ToString(Constants.TIME_FORMAT);
        set => TimeUnassigned = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? TimeUnassigned { get; set; }

    [JsonPropertyName("dateassigned")]
    [XmlElement("dateassigned")]
    [Browsable(false)]
    public string DateAssignedString
    {
        get => DateAssigned?.ToString(Constants.DATE_FORMAT);
        set => DateAssigned = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? DateAssigned { get; set; }

    [JsonPropertyName("user")]
    [XmlElement("user")]
    public TaskUser User { get; set; }

    [JsonPropertyName("timeassigned")]
    [XmlElement("timeassigned")]
    [Browsable(false)]
    public string TimeAssignedString
    {
        get => TimeAssigned?.ToString(Constants.TIME_FORMAT);
        set => TimeAssigned = DateTimeHelpers.TrySetDate(value);
    }

    [JsonIgnore]
    [XmlIgnore]
    public DateTime? TimeAssigned { get; set; }
}

public class TaskStage
{
    [JsonPropertyName("stageid")]
    [XmlElement("stageid")]
    public string StageId { get; set; }

    [JsonPropertyName("stagename")]
    [XmlElement("stagename")]
    public string StageName { get; set; }
}
