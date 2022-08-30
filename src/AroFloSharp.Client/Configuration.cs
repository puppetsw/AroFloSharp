using System;
using AroFloSharp.Client.Enums;

namespace AroFloSharp.Client;

public class Configuration
{
    public TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(5);

    public string SecretKey { get; set; }

    public string UEncode { get; set; }

    public string PEncode { get; set; }

    public string OrgEncode { get; set; }

    public DataFormat DataFormat { get; set; } = DataFormat.Json;

    public string Accept => DataFormat == DataFormat.Json ?
        Constants.ACCEPT_JSON :
        Constants.ACCEPT_XML;


}