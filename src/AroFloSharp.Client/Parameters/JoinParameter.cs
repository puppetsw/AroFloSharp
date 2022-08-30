using System;
using System.Collections.Generic;
using System.Linq;
using AroFloSharp.Client.Enums;

namespace AroFloSharp.Client.Parameters;

public class JoinParameter : ParameterBase
{
    private readonly List<string> _joinFields = new();

    public JoinParameter(string joinField) : base(ParameterType.Join)
    {
        _joinFields.Add(joinField);
    }

    public JoinParameter(IEnumerable<string> joinFields) : base(ParameterType.Join)
    {
        _joinFields.AddRange(joinFields);
    }

    public override string ToString()
    {
        var joinArray = _joinFields.ToArray();
        var joinString = string.Join(",", joinArray);

        return $"{ParameterTypes[Type]}={Uri.EscapeDataString(joinString)}";
    }
}
