namespace AroFloSharp.Serialization.Response;

public class Response<T> where T : ZoneResponseBase
{
    public string Status { get; set; }

    public string StatusMessage { get; set; }

    public T ZoneResponse { get; set; }

}
