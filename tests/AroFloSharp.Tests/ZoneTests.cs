using System.Linq;
using AroFloSharp.Client;
using AroFloSharp.Client.Enums;
using AroFloSharp.Client.Helpers;
using AroFloSharp.Serialization.Response;
using AroFloSharp.Serialization.Serializer;
using AroFloSharp.Tests.Helpers;
using NUnit.Framework;
using Task = System.Threading.Tasks.Task;

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
        TestHelpers.WritePropertiesToConsole(lastupdate);

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
        TestHelpers.WritePropertiesToConsole(lastupdate);

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
        TestHelpers.WritePropertiesToConsole(businessUnits);

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
        TestHelpers.WritePropertiesToConsole(businessUnits);

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
        TestHelpers.WritePropertiesToConsole(businessUnits);
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
        TestHelpers.WritePropertiesToConsole(permissionGroups);

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

        TestHelpers.WritePropertiesToConsole(permissionGroups);
        Assert.IsTrue(permissionGroups.ZoneResponse.PermissionGroups.Count > 0);
    }

    [Test]
    public async Task Test_users_zone_get_json_join_permissiongroups()
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
                parameters.AddZone(Zone.Users);
                parameters.AddWhereAnd("archived", "false");
                parameters.AddJoin("permissiongroups");
                parameters.AddPageNumber(1);
            });

        var users = JsonNetSerializer.Deserialize<UsersZone>(response);

        TestHelpers.WritePropertiesToConsole(users);
        Assert.IsTrue(users.ZoneResponse.Users.Count > 0);
        Assert.IsTrue(users.ZoneResponse.Users.Any(x => x.PermissionGroups.Count > 0));
    }

    [Test]
    public async Task Test_tasks_zone_get_json()
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
                parameters.AddZone(Zone.Tasks);
                parameters.AddPageNumber(1);
                parameters.AddJoin("material", "quote", "customfields", "assignedhistory");
            });

        var tasks = JsonNetSerializer.Deserialize<TasksZone>(response);
        Assert.IsTrue(tasks.ZoneResponse.Tasks.Any(x => x.Materials.Count > 0));
        Assert.IsTrue(tasks.ZoneResponse.Tasks.Any(x => x.Quote != null));
        Assert.IsTrue(tasks.ZoneResponse.Tasks.Any(x => x.AssignedHistory.Count > 0));
    }

    [Test]
    public async Task Test_tasks_zone_get_xml_with_joins()
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
                parameters.AddZone(Zone.Tasks);
                parameters.AddPageNumber(1);
                parameters.AddJoin("material", "quote", "customfields", "assignedhistory");
            });

        var tasks = XmlNetSerializer.Deserialize<TasksZone>(response);
        Assert.IsTrue(tasks.ZoneResponse.Tasks.Any(x => x.Materials.Count > 0));
        Assert.IsTrue(tasks.ZoneResponse.Tasks.Any(x => x.Quote != null));
        Assert.IsTrue(tasks.ZoneResponse.Tasks.Any(x => x.AssignedHistory.Count > 0));
        // Assert.IsTrue(tasks.ZoneResponse.Tasks.Any(x => x.CustomFields.Count > 0));
    }

    [Test]
    public void Test_tasks_zone_api_string_customfields()
    {
        string str = "{\"status\":\"0\",\"statusmessage\":\"Login OK\",\"zoneresponse\":{\"tasks\":[{\"location\":{},\"org\":{\"orgid\":\"JCdKUyZRMCAgCg==\",\"orgname\":\"Bradley Sandbox\"},\"completeddatetime\":\"2018/10/29 00:15:00\",\"priority\":\"0\",\"tasknotes\":[],\"gpslongitude\":\"0\",\"expenses\":[],\"requestdatetime\":\"2018/10/29 08:00:00\",\"status\":\"Not Started\",\"gpslatitude\":\"0\",\"readtaskdatetime\":\"2018/11/08 14:45:42\",\"description\":\"\",\"linkprocesseddate\":\" \",\"refcode\":\"#1 Lad8\",\"tasklocation\":{\"locationid\":\"JSc6QyVRXFwgCg==\",\"locationname\":\"HMAS Sydney Pier 2, Harbour 4, Port of Sydney\"},\"documentsandphotos\":[],\"completeddate\":\"2018/10/29\",\"custon\":\"\",\"duedate\":\"2018/10/29\",\"labours\":[],\"assigneds\":[],\"assets\":[],\"assetid\":\"\",\"project\":{},\"readtask\":\"true\",\"stage\":{},\"lastupdated\":\"2018/11/08\",\"jobnumber\":\"1050\",\"duedatetime\":\"2018/10/29 00:15:00\",\"linkprocessed\":\"false\",\"customfields\":[{\"fieldid\":\"JSZaVyVQTFAgCg==\",\"value\":\"option1\",\"archived\":\"false\",\"type\":\"Select\",\"name\":\"Failure Reason\"},{\"fieldid\":\"JSZaVyVQTFQgCg==\",\"value\":\"Res1\",\"archived\":\"false\",\"type\":\"Select\",\"name\":\"Resolution\"}],\"client\":{\"clientid\":\"JCdKUydRMCAgCg==\",\"clientname\":\"#1 Ladies, Detective Agency\"},\"taskname\":\"HMAS Sydney\",\"taskid\":\"JSZaXyBRTEAgCg==\",\"tasktotals\":{},\"lastupdateddatetime\":\"2018/11/08 14:45:54\",\"requestdate\":\"2018/10/29\",\"tasktype\":\"Maintenance\",\"substatus\":{},\"materials\":[],\"purchaseorders\":[]}],\"maxpageresults\":\"500\",\"pagenumber\":\"1\",\"queryresponsetimes\":{\"tasks\":1,\"customfields\":5},\"currentpageresults\":1}}";
        var tasks = JsonNetSerializer.Deserialize<TasksZone>(str);
        Assert.IsTrue(tasks.ZoneResponse.Tasks.Count > 0);
        Assert.IsTrue(tasks.ZoneResponse.Tasks.Any(x => x.CustomFields.Count > 0));
    }

    [Test]
    public void Test_tasks_api_example_string_with_salesperson()
    {
        string str = "{\"status\":\"0\",\"statusmessage\":\"Login OK\",\"zoneresponse\":{\"tasks\":[{\"location\":{},\"contact\":{\"surname\":\"\",\"givennames\":\"\",\"userid\":\"\"},\"contactname\":\"Bradley Sandbox\",\"org\":{\"orgid\":\"JCdKUyZRMCAgCg==\",\"orgname\":\"Bradley Sandbox\"},\"completeddatetime\":\"2019/10/01 15:19:00\",\"priority\":0,\"tasknotes\":[],\"gpslongitude\":\"144.9607964\",\"expenses\":[],\"requestdatetime\":\"2019/09/30 15:19:44\",\"status\":\"Not Started\",\"gpslatitude\":\"-37.8180446\",\"readtaskdatetime\":\"2019/09/30 15:20:20\",\"description\":\"\",\"linkprocesseddate\":\" \",\"refcode\":\"ABC Bu3\",\"tasklocation\":{\"locationid\":\"\",\"locationname\":\"50 Market St, Melbourne\"},\"documentsandphotos\":[],\"completeddate\":\"2019/10/01\",\"custon\":\"\",\"duedate\":\"2019/10/01\",\"labours\":[],\"assigneds\":[],\"assets\":[],\"assetid\":\"\",\"project\":{},\"readtask\":\"true\",\"stage\":{},\"salesperson\":[{\"surname\":\"Nesbitt\",\"user_id\":\"JCQqQyRQUCAgCg==\",\"givenname\":\"James\"}],\"lastupdated\":\"2019/09/30\",\"jobnumber\":\"1088\",\"duedatetime\":\"2019/10/01 15:19:00\",\"linkprocessed\":\"false\",\"customfields\":[],\"client\":{\"clientid\":\"JCdKUydSUCAgCg==\",\"clientname\":\"ABC Building\"},\"taskname\":\"Test for sortable checklist\",\"taskid\":\"JSZKQyNQPEQgCg==\",\"tasktotals\":{},\"lastupdateddatetime\":\"2019/09/30 15:19:45\",\"requestdate\":\"2019/09/30\",\"contactphone\":\"\",\"tasktype\":\"Service\",\"substatus\":{},\"materials\":[],\"purchaseorders\":[]}],\"maxpageresults\":\"500\",\"pagenumber\":\"1\",\"queryresponsetimes\":{\"tasks\":86,\"salesperson\":1},\"currentpageresults\":1}}";
        var tasks = JsonNetSerializer.Deserialize<TasksZone>(str);
        Assert.IsTrue(tasks.ZoneResponse.Tasks.Count > 0);
    }

    [Test]
    public async Task Test_timesheets_zone_get_json()
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
                parameters.AddZone(Zone.Timesheets);
                parameters.AddPageNumber(1);
            });

        var timesheets = JsonNetSerializer.Deserialize<TimesheetsZone>(response);
        Assert.IsTrue(timesheets.ZoneResponse.Timesheets.Count > 0);
    }
}
