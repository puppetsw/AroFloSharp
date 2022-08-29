using System.Xml.Serialization;

namespace AroFloSharp.Serialization.Models
{
    public class Client
    {
        [XmlElement("orgid")]
        public string Id { get; set; }

        [XmlElement("orgname")]
        public string Name { get; set; }
    }
}
