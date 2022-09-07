using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Models;

namespace AroFloSharp.Serialization.Response;

public class TasksZone : ZoneResponseBase
{
    public override bool IsReadOnly => false;

    public override string[] ValidWheres { get; } =
    {
        "taskid", "clientname", "orgname", "orgid", "jobnumber", "tasktypeid", "status", "daterequested",
        "datetimerequested", "datecompleted", "datetimecompleted", "lastupdatedutc", "lastupdateddatetimeutc",
        "duedate", "duedatetime", "linkprocessed", "linkprocesseddate", "linkprocesseddatetime", "deleteddate",
        "deleteddatetime", "salesperson_givenname", "salesperson_surname", "salesperson_id"
    };

    public override string[] ValidJoins { get; } =
    {
        "documentsandphotos", "notes", "assignedhistory", "material", "labour", "expense", "purchaseorders",
        "assets", "customfields", "location", "locationcustomfields", "project", "tasktotals", "substatus",
        "salesperson"
    };

    public override string[] ValidOrderBys { get; } =
    {
        "clientname", "orgname", "daterequested", "datecompleted", "lastupdated"
    };

    [JsonPropertyName("tasks")]
    [XmlArrayItem("task")]
    [XmlArray("tasks")]
    public List<Task> Tasks { get; set; }
}
