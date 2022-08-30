namespace AroFloSharp.Client.Helpers;

public static class FormatHelpers
{
    public static bool IsJson(this string input)
    {
        input = input.Trim();
        return input.StartsWith("{") && input.EndsWith("}") || input.StartsWith("[") && input.EndsWith("]");
    }
}