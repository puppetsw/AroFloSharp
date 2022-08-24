using System.Xml.Serialization;

namespace AroFloSharp.Client.Responses
{
    public abstract class ZoneResponse<T>
    {
        [XmlElement("maxpageresults")]
        public int MaxPageResults { get; set; }

        [XmlElement("pagenumber")]
        public int PageNumber { get; set; }

        [XmlElement("currentpageresults")]
        public int CurrentPageResults { get; set; }

        [XmlElement("generatedisplayresponsetime")]
        public int GeneratedDisplayResponseTime { get; set; }

        [XmlElement("queryresponsetimes")]
        public int QueryResponseTime { get; set; }

        [XmlIgnore]
        public bool IsMorePages => CurrentPageResults == MaxPageResults;
    }
}
