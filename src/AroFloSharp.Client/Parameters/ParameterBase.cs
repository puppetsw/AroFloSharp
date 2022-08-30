using AroFloSharp.Client.Enums;

#nullable enable

namespace AroFloSharp.Client.Parameters;

public abstract class ParameterBase
{
    protected ParameterType Type { get; }

    protected ParameterBase(ParameterType parameterType)
    {
        Type = parameterType;
    }
}
