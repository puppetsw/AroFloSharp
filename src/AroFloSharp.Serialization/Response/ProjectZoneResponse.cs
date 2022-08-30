using System.Collections.Generic;
using System.Xml.Serialization;
using AroFloSharp.Serialization.Models;
using Newtonsoft.Json;

namespace AroFloSharp.Serialization.Response;

public sealed class ProjectZoneResponse : ZoneResponseBase
{
    [JsonProperty("projects")]
    [XmlArrayItem("project")]
    [XmlArray("projects")]
    public List<Project> Projects { get; set; }
}
