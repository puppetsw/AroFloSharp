using System.Xml.Serialization;
using AroFloSharp.Client.Enums;

namespace AroFloSharp.Client.Response;

[XmlRoot("imsapi")]
public class RequestResponse
{
    [XmlElement("status")]
    public Status Status { get; set; }

    [XmlElement("statusmessage")]
    public string StatusMessage { get; set; }
}