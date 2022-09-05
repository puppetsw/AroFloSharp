using System;
using System.Globalization;
using System.Linq;
using System.Reflection;
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
    public async Task Test_lastupdate_zone_get_json()
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

    [Test]
    public async Task Test_lastupdate_zone_get_xml()
    {
        using var client = new AroFloSharpClient(
            config =>
            {
                config.DataFormat = DataFormat.Xml;
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

        var lastupdate = XmlNetSerializer.Deserialize<LastUpdateZone>(response);

        foreach (var update in lastupdate.ZoneResponse.LastUpdate)
        {
            Console.WriteLine($"{update.ZoneId}, {update.ZoneName}, {update.ZoneIdReference}, {update.LastUpdateUtc.ToString(CultureInfo.CurrentCulture)}");
        }

        Assert.IsTrue(lastupdate.ZoneResponse.LastUpdate.Count > 0);
    }

    [Test]
    public async Task Test_businessunits_zone_get_json()
    {
        using var client = new AroFloSharpClient(
            config =>
            {
                config.SecretKey = Credentials.SECRET_KEY;
                config.UEncode = Credentials.U_ENCODE;
                config.PEncode = Credentials.P_ENCODE;
                config.OrgEncode = Credentials.ORG_ENCODE;
            });
        var response = await client.GetResponseAsync(
            parameters =>
            {
                parameters.AddZone(Zone.BusinessUnits);
                parameters.AddPageNumber(1);
            });

        var businessUnits = JsonNetSerializer.Deserialize<BusinessUnitsZone>(response);

        foreach (var update in businessUnits.ZoneResponse.BusinessUnits)
        {
            var properties = update.GetType().GetProperties();
            foreach (var property in properties)
            {
                Console.WriteLine($"{property.Name}: {property.GetValue(update)}");
            }
        }

        Assert.IsTrue(businessUnits.ZoneResponse.BusinessUnits.Count > 0);
    }

    [Test]
    public async Task Test_businessunits_zone_get_xml()
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
                parameters.AddZone(Zone.BusinessUnits);
                parameters.AddPageNumber(1);
            });

        var businessUnits = XmlNetSerializer.Deserialize<BusinessUnitsZone>(response);

        foreach (var update in businessUnits.ZoneResponse.BusinessUnits)
        {
            var properties = update.GetType().GetProperties();
            foreach (var property in properties)
            {
                Console.WriteLine($"{property.Name}: {property.GetValue(update)}");
            }
        }

        Assert.IsTrue(businessUnits.ZoneResponse.BusinessUnits.Count > 0);
    }

    [Test]
    public async Task Test_businessunits_zone_get_json_join_locations()
    {
        using var client = new AroFloSharpClient(
            config =>
            {
                config.SecretKey = Credentials.SECRET_KEY;
                config.UEncode = Credentials.U_ENCODE;
                config.PEncode = Credentials.P_ENCODE;
                config.OrgEncode = Credentials.ORG_ENCODE;
            });
        var response = await client.GetResponseAsync(
            parameters =>
            {
                parameters.AddZone(Zone.BusinessUnits);
                parameters.AddPageNumber(1);
                parameters.AddJoin("locations");
            });

        var businessUnits = JsonNetSerializer.Deserialize<BusinessUnitsZone>(response);

        foreach (var update in businessUnits.ZoneResponse.BusinessUnits)
        {
            var properties = update.GetType().GetProperties();
            foreach (var property in properties)
            {
                Console.WriteLine($"{property.Name}: {property.GetValue(update)}");
            }
        }

        Assert.IsTrue(businessUnits.ZoneResponse.BusinessUnits.Any(x => x.Locations.Count > 0));
        Assert.IsTrue(businessUnits.ZoneResponse.BusinessUnits.Count > 0);
    }

    [Test]
    public async Task Test_permissiongroups_zone_get_json()
    {
        using var client = new AroFloSharpClient(
            config =>
            {
                config.SecretKey = Credentials.SECRET_KEY;
                config.UEncode = Credentials.U_ENCODE;
                config.PEncode = Credentials.P_ENCODE;
                config.OrgEncode = Credentials.ORG_ENCODE;
            });
        var response = await client.GetResponseAsync(
            parameters =>
            {
                parameters.AddZone(Zone.PermissionGroups);
                parameters.AddPageNumber(1);
            });

        var permissionGroups = JsonNetSerializer.Deserialize<PermissionGroupsZone>(response);

        foreach (var update in permissionGroups.ZoneResponse.PermissionGroups)
        {
            var properties = update.GetType().GetProperties();
            foreach (var property in properties)
            {
                Console.WriteLine($"{property.Name}: {property.GetValue(update)}");
            }
        }

        Assert.IsTrue(permissionGroups.ZoneResponse.PermissionGroups.Count > 0);
    }

    [Test]
    public async Task Test_permissiongroups_zone_get_xml()
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
                parameters.AddZone(Zone.PermissionGroups);
                parameters.AddPageNumber(1);
            });

        var permissionGroups = XmlNetSerializer.Deserialize<PermissionGroupsZone>(response);

        foreach (var update in permissionGroups.ZoneResponse.PermissionGroups)
        {
            var properties = update.GetType().GetProperties();
            foreach (var property in properties)
            {
                Console.WriteLine($"{property.Name}: {property.GetValue(update)}");
            }
        }

        Assert.IsTrue(permissionGroups.ZoneResponse.PermissionGroups.Count > 0);
    }
}
