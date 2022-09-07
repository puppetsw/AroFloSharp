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
public class ContactsZoneTests
{
    // [Test]
    // Our system has no contacts stored. Can't test.
    public async Task Test_contacts_zone_get_xml()
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
                parameters.AddZone(Zone.Contacts);
                parameters.AddPageNumber(1);
            });

        var contacts = XmlNetSerializer.Deserialize<ContactsZone>(response);
        Assert.IsTrue(contacts.ZoneResponse.Contacts.Count > 0);
    }

    [Test]
    public void Test_contacts_zone_get_json()
    {
        var response = ContactsZoneResources.ContactsResponseJson;
        var contacts = JsonNetSerializer.Deserialize<ContactsZone>(response);
        Assert.IsTrue(contacts.ZoneResponse.Contacts.Count > 0);
    }
}
