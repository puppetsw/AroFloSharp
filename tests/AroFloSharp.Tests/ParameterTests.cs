using System;
using AroFloSharp.Client.Enums;
using AroFloSharp.Client.Parameters;
using NUnit.Framework;

namespace AroFloSharp.Tests;

[TestFixture]
public class ParameterTests
{
    [Test]
    public void Test_parameter_ToString()
    {
        var andParam = new AndParameter("clientname", "ClientA", ComparisonOperator.Equal);

        var expected = "where=and%7Cclientname%7C%3D%7CClientA";
        var result = andParam.ToString();

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_zone_parameter_ToString()
    {
        var parameter = new ZoneParameter(AroFloZone.Projects);

        var expected = "zone=projects";
        var result = parameter.ToString();

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_order_parameter_ToString()
    {
        var parameter = new OrderParameter("lastupdateutc", SortOrder.Ascending);

        var expected = "order=lastupdateutc%7Casc";
        var result = parameter.ToString();

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_parameter_collection_ToString()
    {
        var parameters = new ParameterCollection();

        parameters.Add(new ZoneParameter(AroFloZone.Projects));
        parameters.Add(new PageParameter(1));

        var expected = "zone=projects&page=1";
        var result = parameters.ToString();

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_parameter_collection_zone_page_order_ToString()
    {
        var parameters = new ParameterCollection();
        parameters.Add(new ZoneParameter(AroFloZone.Projects));
        parameters.Add(new PageParameter(1));
        parameters.Add(new OrderParameter("lastupdateutc", SortOrder.Ascending));

        var expected = "zone=projects&page=1&order=lastupdateutc%7Casc";
        var result = parameters.ToString();

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_parameter_collection_users_and_or_ToString()
    {
        var parameters = new ParameterCollection();
        parameters.Add(new ZoneParameter(AroFloZone.Users));
        parameters.Add(new AndParameter("givennames", "steve", ComparisonOperator.Equal));
        parameters.Add(new OrParameter("archived", "true", ComparisonOperator.Equal));

        var expected = "zone=users&where=and|givennames|=|steve&where=or|archived|=|true";
        var result = parameters.ToString();

        Assert.AreEqual(expected, Uri.UnescapeDataString(result));
    }

    [Test]
    public void Test_parameter_collection_zone_where_or_where_and_ToString()
    {
        var parameters = new ParameterCollection();

        parameters.Add(new ZoneParameter(AroFloZone.Tasks));

        var where1 = new AndParameter("clientname", "ClientA", ComparisonOperator.Equal);
        where1.Parameters.Add(new OrParameter("clientname", "ClientB", ComparisonOperator.Equal));

        parameters.Add(where1);
        parameters.Add(new AndParameter("daterequested", "2017-12-01", ComparisonOperator.Equal));

        var expected = "zone=tasks&where=and%7C%28%7Cclientname%7C%3D%7CClientA&where=or%7Cclientname%7C%3D%7CClientB%29&where=and%7Cdaterequested%7C%3D%7C2017-12-01";
        var result = parameters.ToString();

        Assert.AreEqual(Uri.UnescapeDataString(expected), Uri.UnescapeDataString(result));
    }
}
