#nullable enable

using System;
using System.Xml.Linq;

namespace AroFloSharp.Tests.Helpers;

public static class TestHelpers
{
    public static bool IsJson(string input)
    {
        input = input.Trim();
        return input.StartsWith("{") && input.EndsWith("}") || input.StartsWith("[") && input.EndsWith("]");
    }

    public static bool IsXml(string str)
    {
        if (!string.IsNullOrEmpty(str) && str.TrimStart().StartsWith("<"))
        {
            try
            {
                var doc = XDocument.Parse(str);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        return false;
    }

    public static void WritePropertiesToConsole(object? obj)
    {

    }
}