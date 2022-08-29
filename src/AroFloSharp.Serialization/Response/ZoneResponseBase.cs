using Newtonsoft.Json;

namespace AroFloSharp.Serialization.Response;

public abstract class ZoneResponseBase
{
    public int MaxPageResults { get; set; }

    public int PageNumber { get; set; }

    public double GenerateDisplayResponseTime { get; set; }

    public int CurrentPageResults { get; set; }
}