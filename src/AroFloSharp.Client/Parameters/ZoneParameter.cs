using System;
using System.Collections.Generic;
using AroFloSharp.Client.Enums;

namespace AroFloSharp.Client.Parameters;

public class ZoneParameter : ParameterBase
{
    private readonly AroFloZone _zone;

    private readonly Dictionary<AroFloZone, string> _zones = new();

    public ZoneParameter(AroFloZone zone) : base(ParameterType.Zone)
    {
        _zone = zone;
        _zones.Add(AroFloZone.Projects, Constants.PROJECTS);
        _zones.Add(AroFloZone.Clients, Constants.CLIENTS);
        _zones.Add(AroFloZone.Locations, Constants.LOCATIONS);
        _zones.Add(AroFloZone.Tasks, Constants.TASKS);
    }

    public override string ToString() => $"{ParameterTypes[Type]}={Uri.EscapeDataString(_zones[_zone])}";
}