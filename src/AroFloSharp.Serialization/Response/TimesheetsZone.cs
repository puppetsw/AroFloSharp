using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Models;

namespace AroFloSharp.Serialization.Response;

public class TimesheetsZone : ZoneResponseBase
{
    public override bool IsReadOnly => true;
    public override string[] ValidWheres { get; } = { "timesheetid", "taskid", "userid", "type", "workdate" };
    public override string[] ValidJoins { get; } = { };
    public override string[] ValidOrderBys { get; } = { "workdate" };

    [JsonPropertyName("timesheets")]
    [XmlArrayItem("timesheet")]
    [XmlArray("timesheets")]
    public List<Timesheet> Timesheets { get; set; }
}