#nullable enable

using System.IO;
using Newtonsoft.Json;

namespace AroFloSharp.Serialization.Serializer;

public class JsonNetSerializer
{
    private readonly JsonSerializer _serializer;

    public JsonNetSerializer()
    {
        _serializer = JsonSerializer.CreateDefault();
    }

    public T? Deserialize<T>(string response)
    {
        using var reader = new JsonTextReader(new StringReader(response)) { CloseInput = true };

       
        
        return _serializer.Deserialize<T>(reader);
    }
}