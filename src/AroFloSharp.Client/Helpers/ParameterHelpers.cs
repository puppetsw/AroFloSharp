using AroFloSharp.Client.Enums;
using AroFloSharp.Client.Parameters;

namespace AroFloSharp.Client.Helpers;

public static class ParameterHelpers
{
    public static ZoneParameter AddZone(this ParameterCollection parameterCollection, Zone zone)
    {
        var zoneParameter = new ZoneParameter(zone);
        parameterCollection.Add(zoneParameter);
        return zoneParameter;
    }

    public static AndParameter AddWhereAnd(this ParameterCollection parameterCollection, string field, string value,
        ComparisonOperator comparisonOperator = ComparisonOperator.Equal)
    {
        var andParameter = new AndParameter(field, value, comparisonOperator);
        parameterCollection.Add(andParameter);
        return andParameter;
    }

    public static AndParameter AddWhereAnd(this AndParameter parameter, string field, string value,
        ComparisonOperator comparisonOperator = ComparisonOperator.Equal)
    {
        var andParameter = new AndParameter(field, value, comparisonOperator);
        parameter.Parameters.Add(andParameter);
        return andParameter;
    }

    public static AndParameter AddWhereAnd(this OrParameter parameter, string field, string value,
        ComparisonOperator comparisonOperator = ComparisonOperator.Equal)
    {
        var andParameter = new AndParameter(field, value, comparisonOperator);
        parameter.Parameters.Add(andParameter);
        return andParameter;
    }

    public static OrParameter AddWhereOr(this ParameterCollection parameterCollection, string field, string value,
        ComparisonOperator comparisonOperator = ComparisonOperator.Equal)
    {
        var orParameter = new OrParameter(field, value, comparisonOperator);
        parameterCollection.Add(orParameter);
        return orParameter;
    }

    public static OrParameter AddWhereOr(this OrParameter parameter, string field, string value,
        ComparisonOperator comparisonOperator = ComparisonOperator.Equal)
    {
        var orParameter = new OrParameter(field, value, comparisonOperator);
        parameter.Parameters.Add(orParameter);
        return orParameter;
    }

    public static OrParameter AddWhereOr(this AndParameter parameter, string field, string value,
        ComparisonOperator comparisonOperator = ComparisonOperator.Equal)
    {
        var orParameter = new OrParameter(field, value, comparisonOperator);
        parameter.Parameters.Add(orParameter);
        return orParameter;
    }

    public static PageParameter AddPageNumber(this ParameterCollection parameterCollection, int pageNumber)
    {
        var pageParameter = new PageParameter(pageNumber);
        parameterCollection.Add(pageParameter);
        return pageParameter;
    }

    public static PageSizeParameter AddPageSize(this ParameterCollection parameterCollection, int pageSize)
    {
        var pageSizeParameter = new PageSizeParameter(pageSize);
        parameterCollection.Add(pageSizeParameter);
        return pageSizeParameter;
    }

    public static OrderParameter AddOrder(this ParameterCollection parameterCollection, string orderBy,
        SortOrder sortOrder = SortOrder.Descending)
    {
        var orderParameter = new OrderParameter(orderBy, sortOrder);
        parameterCollection.Add(orderParameter);
        return orderParameter;
    }

    public static JoinParameter AddJoin(this ParameterCollection parameterCollection, string joinOn)
    {
        var joinParameter = new JoinParameter(joinOn);
        parameterCollection.Add(joinParameter);
        return joinParameter;
    }
}
