using System.Linq;
using System.Threading.Tasks;
using AroFloSharp.Client;
using AroFloSharp.Client.Enums;
using AroFloSharp.Client.Helpers;
using AroFloSharp.Serialization.Response;
using AroFloSharp.Serialization.Serializer;
using AroFloSharp.Tests.Properties;
using NUnit.Framework;

namespace AroFloSharp.Tests;

[TestFixture]
public class LocationsZoneTests
{
    [Test] public async Task Test_locations_zone_get_xml()
    {
        using var client = new AroFloSharpClient(
            config =>
            {
                config.DataFormat = DataFormat.Xml;
                config.SecretKey = Credentials.SECRET_KEY;
                config.UEncode = Credentials.U_ENCODE;
                config.PEncode = Credentials.P_ENCODE;
                config.OrgEncode = Credentials.ORG_ENCODE;
            });
        var response = await client.GetResponseAsync(
            parameters =>
            {
                parameters.AddZone(Zone.Locations);
                parameters.AddPageNumber(1);
            });

        var locations = XmlNetSerializer.Deserialize<LocationsZone>(response);
        Assert.IsTrue(locations.ZoneResponse.Locations.Count > 0);
    }

    [Test]
    public async Task Test_locations_zone_get_json_joincustomfields()
    {
        var response = LocationsZoneResources.LocationsZoneJsonResponse;
        var locations = JsonNetSerializer.Deserialize<LocationsZone>(response);
        Assert.IsTrue(locations.ZoneResponse.Locations.Count > 0);
        Assert.IsTrue(locations.ZoneResponse.Locations.Any(x => x.CustomFields.Count > 0));
    }
}
