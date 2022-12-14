using System;
using System.Threading.Tasks;
using AroFloSharp.Client;
using AroFloSharp.Client.Enums;
using AroFloSharp.Client.Parameters;
using NUnit.Framework;

namespace AroFloSharp.Tests;

[TestFixture]
public class RequestMessageTests
{
    [Test]
    public async Task Test_request_message_xml()
    {
        using var client = new Client.AroFloSharpClient(options =>
        {
            options.Timeout = TimeSpan.FromSeconds(5);
            options.DataFormat = DataFormat.Xml;
            options.SecretKey = Credentials.SECRET_KEY;
            options.UEncode = Credentials.U_ENCODE;
            options.PEncode = Credentials.P_ENCODE;
            options.OrgEncode = Credentials.ORG_ENCODE;
        });
        var data = await client.GetResponseAsync(parameters =>
        {
            parameters.Add(new ZoneParameter(Zone.Projects));
            parameters.Add(new PageParameter(1));
        });

        Console.WriteLine(data);
        Assert.IsTrue(client.Status == Status.LoginOk);
        Assert.IsTrue(data != "");
    }

    [Test]
    public async Task Test_request_message_json()
    {
        using var client = new Client.AroFloSharpClient(options =>
        {
            options.Timeout = TimeSpan.FromSeconds(5);
            options.DataFormat = DataFormat.Json;
            options.SecretKey = Credentials.SECRET_KEY;
            options.UEncode = Credentials.U_ENCODE;
            options.PEncode = Credentials.P_ENCODE;
            options.OrgEncode = Credentials.ORG_ENCODE;
        });
        var data = await client.GetResponseAsync(parameters =>
        {
            parameters.Add(new ZoneParameter(Zone.Projects));
            parameters.Add(new PageParameter(1));
        });

        Console.WriteLine(data);
        Assert.IsTrue(client.Status == Status.LoginOk);
        Assert.IsTrue(data != "");
    }
}