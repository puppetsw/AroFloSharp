using System;
using AroFloSharp.Client.Enums;
using AroFloSharp.Client.Helpers;

namespace AroFloSharp.Client.Parameters;

public class ZoneParameter : ParameterBase
{
    private readonly Zone _zone;

    public ZoneParameter(Zone zone) : base(ParameterType.Zone)
    {
        _zone = zone;
    }

    public override string ToString() => $"{Type.GetString()}={Uri.EscapeDataString(_zone.GetString())}";
}