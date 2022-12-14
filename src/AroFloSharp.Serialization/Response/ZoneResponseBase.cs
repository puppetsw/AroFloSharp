using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace AroFloSharp.Serialization.Response;

public abstract class ZoneResponseBase
{
    [JsonIgnore]
    [XmlIgnore]
    public abstract bool IsReadOnly { get; }

    [JsonIgnore]
    [XmlIgnore]
    public abstract string[] ValidWhereFilters { get; }

    public int MaxPageResults { get; set; }

    public int PageNumber { get; set; }

    public double GenerateDisplayResponseTime { get; set; }

    public int CurrentPageResults { get; set; }
}