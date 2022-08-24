using System.Xml.Serialization;

namespace AroFloSharp.Client.Responses
{
    [XmlRoot("imsapi")]
    public class AroFloResponse<T>
    {
        [XmlElement("status")]
        public string Status { get; set; }

        [XmlElement("statusmessage")]
        public string StatusMessage { get; set; }

        [XmlElement("zoneresponse")]
        public T ZoneResponse { get; set; }
    }
}
