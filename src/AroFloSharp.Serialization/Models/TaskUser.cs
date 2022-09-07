using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace AroFloSharp.Serialization.Models;

public class TaskUser
{
    [JsonPropertyName("userid")]
    [XmlElement("userid")]
    public string UserId { get; set; }

    [JsonPropertyName("username")]
    [XmlElement("username")]
    public string Username { get; set; }
}
