using System;
using System.Threading.Tasks;
using AroFloSharp.Client;
using AroFloSharp.Client.Enums;
using AroFloSharp.Client.Parameters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AroFloSharp.Tests
{
    [TestClass]
    public class RequestMessageTests
    {

        [TestMethod]
        public async Task Test_request_message()
        {
            using var client = new AroFloSharpClient(options =>
            {
                options.Timeout = TimeSpan.FromSeconds(5);
                options.DataFormat = DataFormat.Json;
                options.SecretKey = Credentials.SECRET_KEY;
                options.UEncode = Credentials.U_ENCODE;
                options.PEncode = Credentials.P_ENCODE;
                options.OrgEncode = Credentials.ORG_ENCODE;
            });
            var data = await client.GetResponseAsync(
                parameters =>
                {
                    parameters.Add(new ZoneParameter(AroFloZone.Projects));
                    parameters.Add(new PageParameter(1));
                });

            Console.WriteLine(data);

            Assert.IsTrue(data != "");
        }
    }
}
