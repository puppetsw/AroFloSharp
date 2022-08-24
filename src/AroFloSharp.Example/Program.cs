using System;
using System.Threading.Tasks;
using AroFloSharp.Client;

namespace AroFloSharp.Example
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using (var client = new AroFloSharpClient(options =>
                   {
                       options.Timeout = TimeSpan.FromSeconds(5);
                       options.SecretKey = "RHIzTUFiUlJhSUpPenNQaFA2WHBzcGMzYXJlM1RxMCtDVW5uNkRKdnhITzI1S0krNW4vM0NZdk45SnlnNFFTaG1wcnB0WXBlRGMzNlFYeDEwVE9Wbmc9PQ==";
                       options.UEncode = "PjZPQjtBSEM7RihdOjI6JDJMKlwgJiohQ0AxTVw4Klg9Jzk6NDUpWiwK";
                       options.PEncode = "cTdod3FkODFlNnI0TGVk";
                       options.OrgEncode = "JSc6TyBQLFAgCg==";

                   }))
            {
                var projects = await client.GetProjectsAsync();
                Console.WriteLine($"Number of projects {projects.Count}");
            }

            Console.ReadLine();
        }
    }
}
