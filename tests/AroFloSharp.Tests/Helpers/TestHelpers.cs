#nullable enable

using System;
using System.CodeDom.Compiler;
using System.IO;
using System.Text;
using System.Xml.Linq;
using YamlDotNet.Serialization;

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
        if (obj is null)
        {
            return;
        }

        var stringBuilder = new StringBuilder();
        var serializer = new Serializer();
        serializer.Serialize(new IndentedTextWriter(new StringWriter(stringBuilder)), obj);
        Console.WriteLine(stringBuilder);
    }
}
