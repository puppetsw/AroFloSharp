using AroFloSharp.Client.Enums;

namespace AroFloSharp.Client.Parameters;

public class OrParameter : WhereParameterBase
{
    public OrParameter(string field, string value, ComparisonOperator comparisonOperator)
        : base(field, value, comparisonOperator, StatementOperator.Or)
    {
    }
}
