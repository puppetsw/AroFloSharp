using System.Linq;
using AroFloSharp.Serialization.Response;
using AroFloSharp.Serialization.Serializer;
using AroFloSharp.Tests.Properties;
using NUnit.Framework;

namespace AroFloSharp.Tests;

[TestFixture]
public class QuotesZoneTests
{
    [Test]
    public void Test_clients_zone_join_locations_json()
    {
        var jsonStr = QuotesZoneResources.ZoneResponse_Join_Lines_Notes_Project_DocandPhotos;
        var quotes = JsonNetSerializer.Deserialize<QuotesZone>(jsonStr);
        Assert.IsTrue(quotes.ZoneResponse.Quotes.Count > 0);
        Assert.IsTrue(quotes.ZoneResponse.Quotes.Any(x => x.Lines.Count > 0));
    }
}