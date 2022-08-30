using System;
using AroFloSharp.Client.Enums;
using AroFloSharp.Client.Helpers;

namespace AroFloSharp.Client.Parameters;

public class OrderParameter : ParameterBase
{
    private readonly string _columnName;
    private readonly SortOrder _sortOrder;

    public OrderParameter(string columnName, SortOrder sortOrder) : base(ParameterType.Order)
    {
        _columnName = columnName;
        _sortOrder = sortOrder;
    }

    public override string ToString()
    {
        string orderText = _sortOrder == SortOrder.Ascending ? Constants.ASCENDING : Constants.DESCENDING;
        return $"{Type.GetString()}={Uri.EscapeDataString($"{_columnName}|{orderText}")}";
    }
}