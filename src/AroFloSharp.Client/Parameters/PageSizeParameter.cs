using System;
using AroFloSharp.Client.Enums;

namespace AroFloSharp.Client.Parameters;

public class PageSizeParameter : ParameterBase
{
    private readonly int _pageSize;

    public PageSizeParameter(int pageSize) : base(ParameterType.PageSize)
    {
        _pageSize = pageSize;
    }

    public override string ToString() => $"{ParameterTypes[Type]}={Uri.EscapeDataString(_pageSize.ToString())}";
}