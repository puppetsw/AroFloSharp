using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;

namespace AroFloSharp.Client
{
    public static class HttpHelpers
    {
        public static void GenerateHeaders(this HttpRequestMessage requestMessage, AroFloSharpOptions options, string zone, int page)
        {
            // HEADER SECTION
            // DATE
            var isoTimeStamp = DateTime.UtcNow.ToString("o");
            const string urlPath = "";
            const string accept = "text/xml";
            // const string accept = "text/json";

            // AUTHORIZATION
            var authString = new StringBuilder();
            authString.Append($"uencoded={Uri.EscapeDataString(options.UEncode)}");
            authString.Append($"&pencoded={Uri.EscapeDataString(options.PEncode)}");
            authString.Append($"&orgEncoded={Uri.EscapeDataString(options.OrgEncode)}");
            var authorization = authString.ToString();

            // Create the payload for hashing
            var payloadArray = new List<string>
            {
                "GET",
                urlPath,
                accept,
                authorization,
                isoTimeStamp,
                $"{zone}{page}"
            };

            // PAYLOAD
            var payload = string.Join("+", payloadArray.ToArray());
            Console.WriteLine($"Header payload: {payload}");

            // HASH
            var hash = GetHash(payload, options.SecretKey);

            requestMessage.Headers.Add("Authentication", $"HMAC {hash}");
            // ADD WITHOUT VALIDATION
            requestMessage.Headers.TryAddWithoutValidation("Authorization", authorization);
            requestMessage.Headers.Add("Accept", accept);
            requestMessage.Headers.Add("afdatetimeutc", isoTimeStamp);
        }
        
        private static string GetHash(string text, string key)
        {
            using (var hmacsha = new HMACSHA512(Encoding.UTF8.GetBytes(key)))
            {
                var hash = hmacsha.ComputeHash(Encoding.UTF8.GetBytes(text));
                return BitConverter.ToString(hash).Replace("-", string.Empty);
            }
        }
    }
}
