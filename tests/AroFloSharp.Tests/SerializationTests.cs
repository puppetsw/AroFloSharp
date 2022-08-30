using System;
using System.Threading.Tasks;
using AroFloSharp.Client;
using AroFloSharp.Client.Enums;
using AroFloSharp.Client.Parameters;
using AroFloSharp.Serialization.Models;
using AroFloSharp.Serialization.Response;
using AroFloSharp.Serialization.Serializer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AroFloSharp.Tests;

[TestClass]
public class SerializationTests
{
    [TestMethod]
    public async Task Test_basic_deserialization_Projects()
    {
        using var client = new AroFloSharpClient(config =>
        {
            config.SecretKey = Credentials.SECRET_KEY;
            config.UEncode = Credentials.U_ENCODE;
            config.PEncode = Credentials.P_ENCODE;
            config.OrgEncode = Credentials.ORG_ENCODE;
        });

        var data = await client.GetResponseAsync(parameters =>
        {
            parameters.Add(new ZoneParameter(AroFloZone.Projects));
            // parameters.Add(new AndParameter("projectnumber", "20", ComparisonOperator.Equal));
            // parameters.Add(new PageParameter(1));
            // parameters.Add(new PageSizeParameter(500));
            // parameters.Add(new AndParameter("status", "open", ComparisonOperator.Equal));
        });

        var serializer = new JsonNetSerializer();

        var projects = serializer.Deserialize<Response<ProjectZoneResponse>>(data);

        Assert.IsTrue(projects.ZoneResponse.Projects.Count > 0);
    }

    [TestMethod]
    public void Test_basic_serialization_Project()
    {
        var project = new Project { ProjectId = "TEST" };

        using var serializer = new JsonNetSerializer();

        var result = serializer.Serialize(project);
        Console.WriteLine(result);
    }
}