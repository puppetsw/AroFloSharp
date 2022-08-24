using System.Collections.Generic;
using System.Xml.Serialization;
using AroFloSharp.Client.Models;

namespace AroFloSharp.Client.Responses
{
    public class ProjectZoneResponse : ZoneResponse<Project>
    {
        [XmlArrayItem("project")]
        [XmlArray("projects")]
        public List<Project> Results { get; set; }
    }
}
