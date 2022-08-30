using AroFloSharp.Client.Enums;

namespace AroFloSharp.Client.Helpers;

public static class StringHelpers
{
    public static string GetString(this Zone zone) => Constants.Zones[zone];

    public static string GetString(this ParameterType parameterType) =>
        Constants.ParameterTypes[parameterType];

    public static string GetString(this StatementOperator statementOperator) =>
        Constants.StatementOperators[statementOperator];

    public static string GetString(this ComparisonOperator comparisonOperator) =>
        Constants.ComparisonOperators[comparisonOperator];
}
