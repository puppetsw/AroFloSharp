using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using AroFloSharp.Client.Enums;

namespace AroFloSharp.Client.Request;

public static class RequestHeaders
{
    private const string DATE_FORMAT_STRING = "o";
    private const string AUTHENTICATION_HEADER = "Authentication";
    private const string AUTHORIZATION_HEADER = "Authorization";
    private const string ACCEPT_HEADER = "Accept";
    private const string AF_DATE_TIME_UTC_HEADER = "afdatetimeutc";

    public static void AddDefaultHeaders(this RequestMessage requestMessage, AroFloSharpConfig config)
    {
        var authString = new StringBuilder();
        authString.Append($"uencoded={Uri.EscapeDataString(config.UEncode)}");
        authString.Append($"&pencoded={Uri.EscapeDataString(config.PEncode)}");
        authString.Append($"&orgEncoded={Uri.EscapeDataString(config.OrgEncode)}");
        var authorization = authString.ToString();

        var accept = config.DataFormat == DataFormat.Xml ? Constants.ACCEPT_XML : Constants.ACCEPT_JSON;
        var isoTimeStamp = DateTime.UtcNow.ToString(DATE_FORMAT_STRING);

        var payloadArray = new List<string>
        {
            requestMessage.Method == HttpMethod.Get ? "GET" : "POST",
            "", // URL PATH
            accept,
            authorization,
            isoTimeStamp,
            $"{requestMessage.Parameters}"
        };

        var payload = string.Join("+", payloadArray.ToArray());
        Console.WriteLine($"{payload}");

        // HASH
        var hash = GetHash(payload, config.SecretKey);

        requestMessage.Headers.Add(AUTHENTICATION_HEADER, $"HMAC {hash}");
        requestMessage.Headers.TryAddWithoutValidation(AUTHORIZATION_HEADER, authorization);
        requestMessage.Headers.Add(ACCEPT_HEADER, accept);
        requestMessage.Headers.Add(AF_DATE_TIME_UTC_HEADER, isoTimeStamp);
    }

    private static string GetHash(string text, string key)
    {
        using var hmacsha = new HMACSHA512(Encoding.UTF8.GetBytes(key));

        var hash = hmacsha.ComputeHash(Encoding.UTF8.GetBytes(text));
        return BitConverter.ToString(hash).Replace("-", string.Empty);
    }
}