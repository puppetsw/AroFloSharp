using System.Xml.Serialization;

namespace AroFloSharp.Client.Models
{
    public class Project
    {
        [XmlElement("status")]
        public string Status { get; set; }

        [XmlElement("client")]
        public Client Client { get; set; }

        [XmlElement("location")]
        public Location Location { get; set; }

        [XmlElement("projectid")]
        public string ProjectId { get; set; }

        [XmlElement("projectnumber")]
        public int ProjectNumber { get; set; }

        [XmlElement("projectname")]
        public string ProjectName { get; set; }

        [XmlElement("projecttype")]
        public ProjectType ProjectType { get; set; }

        [XmlElement("custon")]
        public string CustomerOrderNumber { get; set; }

        [XmlElement("description")]
        public string Description { get; set; }
    }
}
