using System;
using System.Threading.Tasks;
using AroFloSharp.Client;
using AroFloSharp.Client.Enums;
using AroFloSharp.Client.Helpers;
using AroFloSharp.Serialization.Models;
using AroFloSharp.Serialization.Response;
using AroFloSharp.Serialization.Serializer;
using AroFloSharp.Tests.Helpers;
using NUnit.Framework;
using Task = System.Threading.Tasks.Task;

namespace AroFloSharp.Tests;

[TestFixture]
public class SerializationXmlTests
{
    private string _testData;

    [SetUp]
    public async Task Test_Setup()
    {
        using var client = new AroFloSharpClient(config =>
        {
            config.DataFormat = DataFormat.Xml;
            config.SecretKey = Credentials.SECRET_KEY;
            config.UEncode = Credentials.U_ENCODE;
            config.PEncode = Credentials.P_ENCODE;
            config.OrgEncode = Credentials.ORG_ENCODE;
        });

        _testData = await client.GetResponseAsync(parameters =>
        {
            parameters.AddZone(Zone.Projects);
        });
    }

    [TearDown]
    public void Test_Cleanup() { }

    [Test]
    public void Test_xml_deserialization()
    {
        var projects = XmlNetSerializer.Deserialize<ProjectsZone>(_testData);
        Assert.IsTrue(projects.ZoneResponse.Projects.Count > 0);
    }

    [Test]
    public void Test_xml_serialize()
    {
        var project = new Project { ProjectId = "TEST" };
        var result = XmlNetSerializer.Serialize(project);
        Assert.IsTrue(TestHelpers.IsXml(result));
    }

    [Test]
    public void Test_xml_serialize_multiple()
    {
        var project1 = new Project { ProjectId = "TEST1" };
        var project2 = new Project { ProjectId = "TEST2" };

        var projects = new[] { project1, project2 };

        var result = XmlNetSerializer.Serialize(projects);
        Console.WriteLine(result);
        Assert.IsTrue(TestHelpers.IsXml(result));
    }
}
