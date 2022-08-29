using System.Collections.Generic;
using AroFloSharp.Client.Enums;

#nullable enable

namespace AroFloSharp.Client.Parameters;

public abstract class ParameterBase
{
    protected ParameterType Type { get; }

    protected Dictionary<ParameterType, string> ParameterTypes { get; } = new();

    protected ParameterBase(ParameterType parameterType)
    {
        Type = parameterType;

        ParameterTypes.Add(ParameterType.Zone, Constants.ZONE);
        ParameterTypes.Add(ParameterType.Page, Constants.PAGE);
        ParameterTypes.Add(ParameterType.Where, Constants.WHERE);
        ParameterTypes.Add(ParameterType.Order, Constants.ORDER);
    }
}
