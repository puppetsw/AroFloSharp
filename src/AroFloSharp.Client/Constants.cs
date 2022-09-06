using AroFloSharp.Client.Enums;
using System.Collections.Generic;

namespace AroFloSharp.Client;

public static class Constants
{
    // Base URL
    public const string AROFLO_API_URL = "https://api.aroflo.com/";

    // Data Formats (Accept)
    public const string ACCEPT_JSON = "text/json";
    public const string ACCEPT_XML = "text/xml";

    // Comparison Operators
    public const string EQUAL = "=";
    public const string NOT_EQUAL = "!=";
    public const string GREATER_THAN = ">";
    public const string LESS_THAN = "<";
    public const string IN = "IN";
    public const string NOT_IN = "NOT IN";

    // Statement Operators
    public const string AND = "and";
    public const string OR = "or";

    // Param Types
    public const string ZONE = "zone";
    public const string PAGE = "page";
    public const string WHERE = "where";
    public const string ORDER = "order";
    public const string JOIN = "join";
    public const string PAGE_SIZE = "pageSize";

    // AroFlo Zones
    public const string PROJECTS = "projects";
    public const string CLIENTS = "clients";
    public const string LOCATIONS = "locations";
    public const string TASKS = "tasks";
    public const string USERS = "users";
    public const string LAST_UPDATE = "lastupdate";
    public const string BUSINESS_UNITS = "businessunits";
    public const string PERMISSION_GROUPS = "permissiongroups";
    public const string TIMESHEETS = "timesheets";
    public const string TRANSACTION_TERMS = "transactionterms";
    public const string PRIORITIES = "priorities";

    // Other strings

    public const string ASCENDING = "asc";

    public const string DESCENDING = "desc";

    // Enum Lookups
    public static readonly Dictionary<Zone, string> Zones = new()
    {
        {Zone.Projects, PROJECTS},
        {Zone.Clients, CLIENTS},
        {Zone.Locations, LOCATIONS},
        {Zone.Tasks, TASKS},
        {Zone.Users, USERS},
        {Zone.LastUpdate, LAST_UPDATE},
        {Zone.BusinessUnits, BUSINESS_UNITS},
        {Zone.PermissionGroups, PERMISSION_GROUPS},
        {Zone.Timesheets, TIMESHEETS},
        {Zone.TransactionTerms, TRANSACTION_TERMS},
        {Zone.Priorities, PRIORITIES}
    };

    public static readonly Dictionary<ParameterType, string> ParameterTypes = new()
    {
        {ParameterType.Zone, ZONE},
        {ParameterType.Page, PAGE},
        {ParameterType.Where, WHERE},
        {ParameterType.Order, ORDER},
        {ParameterType.Join, JOIN},
        {ParameterType.PageSize, PAGE_SIZE}
    };

    public static readonly Dictionary<ComparisonOperator, string> ComparisonOperators = new()
    {
        {ComparisonOperator.Equal, EQUAL},
        {ComparisonOperator.GreaterThan, GREATER_THAN},
        {ComparisonOperator.LessThan, LESS_THAN},
        {ComparisonOperator.In, IN},
        {ComparisonOperator.NotIn, NOT_IN},
        {ComparisonOperator.NotEqual, NOT_EQUAL}
    };

    public static readonly Dictionary<StatementOperator, string> StatementOperators = new()
    {
        {StatementOperator.And, AND},
        {StatementOperator.Or, OR}
    };
}
