using System;
using System.Collections.Generic;
using System.Text;
using AroFloSharp.Client.Enums;
using AroFloSharp.Client.Helpers;

#nullable enable

namespace AroFloSharp.Client.Parameters;

public abstract class WhereParameterBase : ParameterBase
{
    public List<WhereParameterBase> Parameters { get; } = new();

    public string? Field { get; }

    public string? Value { get; }

    public ComparisonOperator Operator { get; }

    public StatementOperator Statement { get; }

    protected WhereParameterBase(string field, string value, ComparisonOperator comparisonOperator, StatementOperator statementOperator)
        : base(ParameterType.Where)
    {
        Field = field;
        Value = value;
        Operator = comparisonOperator;
        Statement = statementOperator;
    }

    /// <summary>
    /// Creates a query string based on the properties.
    /// </summary>
    /// <returns><see cref="string"/></returns>
    /// <remarks>
    /// Example of an unencoded string;
    /// Get all Tasks for Client A OR Client B where the Date Requested is 1st December 2017
    /// &zone=tasks&where=and|(|clientname|=|ClientA&where=or|clientname|=|ClientB|)&where=and| daterequested|=|2017-12-01
    /// </remarks>
    public override string ToString()
    {
        var sb = new StringBuilder();

        var leftBracket = Parameters.Count > 0 ? "|(" : ""; // additional pipe required when using brackets.
        var rightBracket = Parameters.Count > 0 ? ")" : "";

        sb.Append($"{Type.GetString()}={Uri.EscapeDataString($"{Statement.GetString()}{leftBracket}|{Field}|{Operator.GetString()}|{Value}")}");

        foreach (var parameter in Parameters)
        {
            sb.Append("&");
            sb.Append(parameter);
        }

        sb.Append($"{Uri.EscapeDataString($"{rightBracket}")}");

        return sb.ToString();
    }
}
