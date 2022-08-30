using System;
using AroFloSharp.Client.Enums;
using AroFloSharp.Client.Helpers;

namespace AroFloSharp.Client.Parameters;

public class ZoneParameter : ParameterBase
{
    private readonly AroFloZone _zone;

    public ZoneParameter(AroFloZone zone) : base(ParameterType.Zone)
    {
        _zone = zone;
    }

    public override string ToString() => $"{Type.GetParameterTypeString()}={Uri.EscapeDataString(_zone.GetZoneString())}";
}