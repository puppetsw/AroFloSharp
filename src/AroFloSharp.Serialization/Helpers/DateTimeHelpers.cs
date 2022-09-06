using System;

namespace AroFloSharp.Serialization.Helpers;

public static class DateTimeHelpers
{
    public static DateTime? TrySetDate(string value)
    {
        try
        {
            return DateTime.Parse(value);
        }
        catch
        {
            return null;
        }
    }
}