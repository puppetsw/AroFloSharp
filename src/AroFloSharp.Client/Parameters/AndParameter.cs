using AroFloSharp.Client.Enums;

namespace AroFloSharp.Client.Parameters;

public class AndParameter : WhereParameterBase
{
    public AndParameter(string field, string value, ComparisonOperator comparisonOperator)
        : base(field, value, comparisonOperator, StatementOperator.And)
    {
    }
}