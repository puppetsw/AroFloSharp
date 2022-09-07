using System.Linq;
using AroFloSharp.Serialization.Response;
using AroFloSharp.Serialization.Serializer;
using AroFloSharp.Tests.Properties;
using NUnit.Framework;

namespace AroFloSharp.Tests;

[TestFixture]
public class ClientZoneTests
{
    [Test]
    public void Test_clients_zone_join_locations_json()
    {
        var jsonStr = Resources.ClientZone_JoinLocations;
        var clients = JsonNetSerializer.Deserialize<ClientsZone>(jsonStr);
        Assert.IsTrue(clients.ZoneResponse.Clients.Count > 0);
        Assert.IsTrue(clients.ZoneResponse.Clients.Any(x => x.Locations.Count > 0));
    }

    [Test]
    public void Test_clients_zone_join_locationscstomfields_json()
    {
        var str = "{\"status\":\"0\",\"statusmessage\":\"Login OK\",\"zoneresponse\":{\"maxpageresults\":\"500\",\"pagenumber\":\"1\",\"queryresponsetimes\":{\"locations\":1,\"orgs\":1,\"customfields\":4,\"clients\":47},\"currentpageresults\":1,\"clients\":[{\"contacts\":[],\"locations\":[{\"locationid\":\"43153\",\"gpslat\":\"0\",\"postcode\":\"2000\",\"SiteContact\":\"\",\"state\":\"NSW\",\"suburb\":\"Port of Sydney\",\"SiteEmail\":\"\",\"customfields\":[{\"fieldid\":\"JCYqUyFRICAgCg==\",\"value\":\"ABC123\",\"archived\":\"false\",\"type\":\"text\",\"name\":\"Site ID\"}],\"locationname\":\"HMAS Sydney\",\"country\":\"AUSTRALIA\",\"gpslong\":\"0\",\"address\":\"Pier 2, Harbour 4\",\"archived\":\"FALSE\",\"SitePhone\":\"\"}],\"phone\":\"\",\"firstname\":\"Mriam\",\"email\":\"\",\"abn\":\"\",\"notes\":[],\"datetimeinserted\":\"2018-06-21 10:59:01.8\",\"documentsandphotos\":[],\"link\":{\"orgid\":\"\",\"orgname\":\"\",\"externalid\":\"\"},\"mailingaddress\":{\"country\":\"\",\"postcode\":\"\",\"addressline1\":\"\",\"state\":\"\",\"suburb\":\"\",\"addressline2\":\"\"},\"surname\":\"Makehba\",\"shortname\":\"#1 Lad\",\"termsnote\":\"\",\"terms\":\"\",\"orgs\":[{\"orgid\":\"JCdKUyZRMCAgCg==\",\"orgname\":\"Bradley Sandbox\",\"archived\":\"false\"}],\"customfields\":[],\"clientid\":\"JCdKUydRMCAgCg==\",\"postable\":\"TRUE\",\"usecustompriorities\":\"true\",\"address\":{\"country\":\"\",\"postcode\":\"3134\",\"addressline1\":\"22222\",\"state\":\"VIC\",\"suburb\":\"Ringwood\",\"addressline2\":\"11111\"},\"priorities\":[],\"dateinserted\":\"2018-06-21 10:59:01.8\",\"fax\":\"\",\"clientname\":\"#1 Ladies, Detective Agency\",\"transactionterms\":{\"transactionterm\":\"\",\"transactiontermnote\":\"\",\"transactiontermid\":\"\"},\"website\":\"\",\"datecreated\":\"2018-06-21 10:59:01.8\",\"mobile\":\"\"}]}}";
        var clients = JsonNetSerializer.Deserialize<ClientsZone>(str);
        Assert.IsTrue(clients.ZoneResponse.Clients.Count > 0);
        Assert.IsTrue(clients.ZoneResponse.Clients.Any(x => x.Locations.Any(y => y.CustomFields.Count > 0)));
    }

    [Test]
    public void Test_clients_zone_join_contacts_json()
    {
        var str = "{\"status\":\"0\",\"statusmessage\":\"Login OK\",\"zoneresponse\":{\"maxpageresults\":\"500\",\"pagenumber\":\"1\",\"queryresponsetimes\":{\"contacts\":6,\"orgs\":2,\"clients\":3},\"currentpageresults\":1,\"clients\":[{\"contacts\":[{\"surname\":\"Makehba\",\"givennames\":\"Mriam\",\"phone\":\"\",\"userid\":\"JCQ6XyVRMCAgCg==\",\"username\":\"D63AAD35-D03E-45D9-80FB-5120DA9AE99D\",\"archived\":\"false\",\"fax\":\"\",\"email\":\"\",\"email2\":\"\",\"mobile\":\"\"}],\"locations\":[],\"phone\":\"\",\"firstname\":\"Mriam\",\"email\":\"\",\"abn\":\"\",\"notes\":[],\"datetimeinserted\":\"2018-06-21 10:59:01.8\",\"documentsandphotos\":[],\"link\":{\"orgid\":\"\",\"orgname\":\"\",\"externalid\":\"\"},\"mailingaddress\":{\"country\":\"\",\"postcode\":\"\",\"addressline1\":\"\",\"state\":\"\",\"suburb\":\"\",\"addressline2\":\"\"},\"surname\":\"Makehba\",\"shortname\":\"#1 Lad\",\"termsnote\":\"\",\"terms\":\"\",\"orgs\":[{\"orgid\":\"JCdKUyZRMCAgCg==\",\"orgname\":\"Bradley Sandbox\",\"archived\":\"false\"}],\"customfields\":[],\"clientid\":\"JCdKUydRMCAgCg==\",\"postable\":\"TRUE\",\"usecustompriorities\":\"true\",\"address\":{\"country\":\"\",\"postcode\":\"3134\",\"addressline1\":\"22222\",\"state\":\"VIC\",\"suburb\":\"Ringwood\",\"addressline2\":\"11111\"},\"priorities\":[],\"dateinserted\":\"2018-06-21 10:59:01.8\",\"fax\":\"\",\"clientname\":\"#1 Ladies, Detective Agency\",\"transactionterms\":{\"transactionterm\":\"\",\"transactiontermnote\":\"\",\"transactiontermid\":\"\"},\"website\":\"\",\"datecreated\":\"2018-06-21 10:59:01.8\",\"mobile\":\"\"}]}}";
        var clients = JsonNetSerializer.Deserialize<ClientsZone>(str);
        Assert.IsTrue(clients.ZoneResponse.Clients.Count > 0);
    }

    [Test]
    public void Test_clients_zone_join_customfields_json()
    {
        var str = "{\"status\":\"0\",\"statusmessage\":\"Login OK\",\"zoneresponse\":{\"maxpageresults\":\"500\",\"pagenumber\":\"1\",\"queryresponsetimes\":{\"orgs\":2,\"customfields\":6,\"clients\":2},\"currentpageresults\":1,\"clients\":[{\"contacts\":[],\"locations\":[],\"phone\":\"1300 794 818\",\"firstname\":\"Jason\",\"email\":\"jason.bourne@aroflo.com\",\"abn\":\"\",\"notes\":[],\"datetimeinserted\":\"2018-06-21 10:59:01.8\",\"documentsandphotos\":[],\"link\":{\"orgid\":\"\",\"orgname\":\"\",\"externalid\":\"\"},\"mailingaddress\":{\"country\":\"AUSTRALIA\",\"postcode\":\"\",\"addressline1\":\"\",\"state\":\"NSW\",\"suburb\":\"\",\"addressline2\":\"\"},\"surname\":\"Bourne\",\"shortname\":\"#1 Lad\",\"termsnote\":\"\",\"terms\":\"\",\"orgs\":[{\"orgid\":\"JCdKUyZRMCAgCg==\",\"orgname\":\"Bradley Sandbox\",\"archived\":\"false\"}],\"customfields\":[{\"fieldid\":\"JCZaVyVQUCAgCg==\",\"value\":\"Word of Mouth\",\"archived\":\"false\",\"type\":\"Select\",\"name\":\"Ad Source\"}],\"clientid\":\"JCdKUydRMCAgCg==\",\"postable\":\"TRUE\",\"usecustompriorities\":\"true\",\"address\":{\"country\":\"AUSTRALIA\",\"postcode\":\"3134\",\"addressline1\":\"22222\",\"state\":\"VIC\",\"suburb\":\"Ringwood\",\"addressline2\":\"11111\"},\"priorities\":[],\"dateinserted\":\"2018-06-21 10:59:01.8\",\"fax\":\"03 XXXX XXXX\",\"clientname\":\"#1 Ladies, Detective Agency\",\"transactionterms\":{\"transactionterm\":\"\",\"transactiontermnote\":\"\",\"transactiontermid\":\"\"},\"website\":\"\",\"datecreated\":\"2018-06-21 00:00:00.0\",\"mobile\":\"04XX XXX XXX\"}]}}";
        var clients = JsonNetSerializer.Deserialize<ClientsZone>(str);
        Assert.IsTrue(clients.ZoneResponse.Clients.Count > 0);
        Assert.IsTrue(clients.ZoneResponse.Clients.Any(x => x.CustomFields.Count > 0));

    }
}