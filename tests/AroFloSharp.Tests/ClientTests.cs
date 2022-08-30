using System;
using System.Threading.Tasks;
using AroFloSharp.Client;
using AroFloSharp.Client.Enums;
using NUnit.Framework;

namespace AroFloSharp.Tests;

[TestFixture]
public class ClientTests
{
    [Test]
    public Task Test_no_zone_parameter()
    {
        async Task TestShouldThrowInvalidOperation()
        {
            using var client = new AroFloSharpClient(options =>
            {
                options.DataFormat = DataFormat.Json;
                options.SecretKey = Credentials.SECRET_KEY;
                options.UEncode = Credentials.U_ENCODE;
                options.PEncode = Credentials.P_ENCODE;
                options.OrgEncode = Credentials.ORG_ENCODE;
            });

            await client.GetResponseAsync(param => {});
        }

        Assert.ThrowsAsync<InvalidOperationException>(TestShouldThrowInvalidOperation);
        return Task.FromResult(Task.CompletedTask);
    }
}
