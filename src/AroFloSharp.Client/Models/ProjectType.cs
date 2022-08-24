using System.Xml.Serialization;

namespace AroFloSharp.Client.Models
{
    public class ProjectType
    {
        [XmlElement("projecttypeid")]
        public string Id { get; set; }

        [XmlElement("projecttype")]
        public string Type { get; set; }
    }
}
