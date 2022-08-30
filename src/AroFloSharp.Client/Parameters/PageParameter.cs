using System;
using System.Collections.Generic;
using AroFloSharp.Client.Enums;
using AroFloSharp.Client.Helpers;

namespace AroFloSharp.Client.Parameters;

public class PageParameter : ParameterBase
{
    private readonly int _pageNumber;

    public PageParameter(int pageNumber) : base(ParameterType.Page)
    {
        _pageNumber = pageNumber;
    }

    public override string ToString() => $"{Type.GetParameterTypeString()}={Uri.EscapeDataString(_pageNumber.ToString())}";
}