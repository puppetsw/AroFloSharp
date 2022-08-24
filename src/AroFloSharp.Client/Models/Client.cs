using System.Xml.Serialization;

namespace AroFloSharp.Client.Models
{
    public class Client
    {
        [XmlElement("orgid")]
        public string Id { get; set; }

        [XmlElement("orgname")]
        public string Name { get; set; }
    }
}
