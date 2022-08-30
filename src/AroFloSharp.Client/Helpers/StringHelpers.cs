using System;
using AroFloSharp.Client.Enums;

namespace AroFloSharp.Client.Helpers;

public static class StringHelpers
{
    public static string GetZoneString(this AroFloZone zone) => Constants.Zones[zone];

    public static string GetParameterTypeString(this ParameterType parameterType) =>
        Constants.ParameterTypes[parameterType];
}