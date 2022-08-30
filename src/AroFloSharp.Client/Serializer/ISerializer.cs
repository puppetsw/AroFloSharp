using AroFloSharp.Client.Response;

namespace AroFloSharp.Client.Serializer;

public interface ISerializer
{
    RequestResponse Deserialize(string responseString);
}