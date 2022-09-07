using System.Linq;
using AroFloSharp.Client;
using AroFloSharp.Client.Enums;
using AroFloSharp.Client.Helpers;
using AroFloSharp.Serialization.Response;
using AroFloSharp.Serialization.Serializer;
using NUnit.Framework;
using Task = System.Threading.Tasks.Task;

namespace AroFloSharp.Tests;

[TestFixture]
public class SerializationJsonTests
{
    private string _testData;

    [SetUp]
    public async Task Test_Setup()
    {
        using var client = new AroFloSharpClient(config =>
        {
            config.SecretKey = Credentials.SECRET_KEY;
            config.UEncode = Credentials.U_ENCODE;
            config.PEncode = Credentials.P_ENCODE;
            config.OrgEncode = Credentials.ORG_ENCODE;
        });

        _testData = await client.GetResponseAsync(parameters =>
        {
            parameters.AddZone(Zone.Projects);
            // parameters.AddWhereAnd("projectnunber", "20", ComparisonOperator.Equal);
            // parameters.Add(new ZoneParameter(AroFloZone.Projects));
            // parameters.Add(new AndParameter("projectnumber", "20", ComparisonOperator.Equal));
            // parameters.Add(new PageParameter(1));
            // parameters.Add(new PageSizeParameter(500));
            // parameters.Add(new AndParameter("status", "open", ComparisonOperator.Equal));
        });
    }

    [TearDown]
    public void Test_Cleanup()
    {
    }

    [Test]
    public void Test_basic_deserialization_Projects()
    {
        var projects = JsonNetSerializer.Deserialize<ProjectsZone>(_testData);
        Assert.IsTrue(projects?.ZoneResponse.Projects.Count > 0);
        Assert.IsTrue(projects.ZoneResponse.Projects.Any(x => x.ProjectType != null));
        Assert.IsTrue(projects.ZoneResponse.Projects.Any(x => x.ProjectType.Type != null));
    }
}
