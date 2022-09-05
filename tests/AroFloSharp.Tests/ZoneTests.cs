using System;
using System.Globalization;
using System.Threading.Tasks;
using AroFloSharp.Client;
using AroFloSharp.Client.Enums;
using AroFloSharp.Client.Helpers;
using AroFloSharp.Serialization.Response;
using AroFloSharp.Serialization.Serializer;
using NUnit.Framework;

namespace AroFloSharp.Tests;

[TestFixture]
public class ZoneTests
{
    [Test]
    public async Task Test_lastupdate_zone_get()
    {
        using var client = new AroFloSharpClient(
            config =>
            {
                config.SecretKey = Credentials.SECRET_KEY;
                config.UEncode   = Credentials.U_ENCODE;
                config.PEncode   = Credentials.P_ENCODE;
                config.OrgEncode = Credentials.ORG_ENCODE;
            });
        var response = await client.GetResponseAsync(
            parameters =>
            {
                parameters.AddZone(Zone.LastUpdate);
                parameters.AddPageNumber(1);
            });

        var lastupdate = JsonNetSerializer.Deserialize<LastUpdateZone>(response);

        foreach (var update in lastupdate.ZoneResponse.LastUpdate)
        {
            Console.WriteLine($"{update.ZoneId}, {update.ZoneName}, {update.ZoneIdReference}, {update.LastUpdateUtc.ToString(CultureInfo.CurrentCulture)}");
        }

        Assert.IsTrue(lastupdate.ZoneResponse.LastUpdate.Count > 0);
    }


}
