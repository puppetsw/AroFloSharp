using System;
using System.Collections.Generic;
using System.Text;
using AroFloSharp.Client.Enums;

#nullable enable

namespace AroFloSharp.Client.Parameters;

public abstract class WhereParameterBase : ParameterBase
{
    public List<WhereParameterBase> Parameters { get; } = new();

    public string? Field { get; }

    public string? Value { get; }

    public ComparisonOperator Operator { get; }

    public StatementOperator Statement { get; }

    private Dictionary<ComparisonOperator, string> ComparisonOperators { get; } = new();

    private Dictionary<StatementOperator, string> StatementOperators { get; } = new();

    protected WhereParameterBase(string field, string value, ComparisonOperator comparisonOperator, StatementOperator statementOperator)
        : base(ParameterType.Where)
    {
        Field = field;
        Value = value;
        Operator = comparisonOperator;
        Statement = statementOperator;

        ComparisonOperators.Add(ComparisonOperator.Equal, Constants.EQUAL);
        ComparisonOperators.Add(ComparisonOperator.GreaterThan, Constants.GREATER_THAN);
        ComparisonOperators.Add(ComparisonOperator.LessThan, Constants.LESS_THAN);
        ComparisonOperators.Add(ComparisonOperator.In, Constants.IN);
        ComparisonOperators.Add(ComparisonOperator.NotIn, Constants.NOT_IN);
        ComparisonOperators.Add(ComparisonOperator.NotEqual, Constants.NOT_EQUAL);

        StatementOperators.Add(StatementOperator.And, Constants.AND);
        StatementOperators.Add(StatementOperator.Or, Constants.OR);
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

        sb.Append($"{ParameterTypes[Type]}={Uri.EscapeDataString($"{StatementOperators[Statement]}{leftBracket}|{Field}|{ComparisonOperators[Operator]}|{Value}")}");

        foreach (var parameter in Parameters)
        {
            sb.Append("&");
            sb.Append(parameter);
        }

        sb.Append($"{Uri.EscapeDataString($"{rightBracket}")}");

        return sb.ToString();
    }
}
