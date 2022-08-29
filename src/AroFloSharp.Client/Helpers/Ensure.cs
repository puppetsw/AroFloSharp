using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#nullable enable

namespace AroFloSharp.Client.Helpers;

public static class Ensure
{
    public static T NotNull<T>(T? value, string name) => value ?? throw new ArgumentNullException(name);

    public static string NotEmpty(string? value, string name) => string.IsNullOrWhiteSpace(value) ? throw new ArgumentNullException(name) : value!;

    public static string NotEmptyString(object? value, string name)
    {
        var s = value as string ?? value?.ToString();
        return string.IsNullOrWhiteSpace(s) ? throw new ArgumentNullException(name) : s!;
    }
}