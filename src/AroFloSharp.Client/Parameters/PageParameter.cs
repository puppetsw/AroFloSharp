using System;
using System.Collections.Generic;
using AroFloSharp.Client.Enums;

namespace AroFloSharp.Client.Parameters;

public class PageParameter : ParameterBase
{
    private readonly int _pageNumber;

    public PageParameter(int pageNumber) : base(ParameterType.Page)
    {
        _pageNumber = pageNumber;
    }

    public override string ToString() => $"{ParameterTypes[Type]}={Uri.EscapeDataString(_pageNumber.ToString())}";
}