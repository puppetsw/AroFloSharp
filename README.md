# AroFloSharp

The AroFloSharp library provides easy access to the [AroFlo](https://www.aroflo.com) API.

# Contents
1. [Supported Platforms](#supported-platforms)
2. [Getting Started](#getting-started)
3. [Examples](#examples)
   1. [Usage](#usage)
   2. [Paging](#paging)
   3. [Where](#where)
   4. [Order By](#order-by)
4. [Documentation](#documentation)
5. [Build](#build)
6. [Contribute](#contribute)
7. [Copyright and License](#copyright-and-license)

# Supported Platforms
* .NET Standard 2.0

# Getting Started

AroFloSharp is a [AroFlo](https://www.aroflo.com) API client library for .NET and *will be* available on NuGet:

`
dotnet add package AroFloSharp
`

# Examples

## Usage

```cs
using var client = new AroFloSharpClient(
config =>
{
    config.SecretKey = Credentials.SECRET_KEY;
    config.UEncode = Credentials.U_ENCODE;
    config.PEncode = Credentials.P_ENCODE;
    config.OrgEncode = Credentials.ORG_ENCODE;
});
var response = await client.GetResponseAsync(
parameters =>
{
    parameters.Add(new ZoneParameter(AroFloZone.Projects));
    parameters.Add(new PageParameter(1));
});

using serializer = new JsonNewtonsoftSerializer();
var projects = serializer.Deserialize<Response<ProjectZoneResponse>>(response);
```

The above example will generate the following AroFlo request string. `zone=projects&page=1` The API keys can be accessed after setting up and being approved for the AroFlo API access.

### Status & Status Message

```cs
client.Status
client.StatusMessage
```

You can access the status and message of the request from the client with the above.

## Paging

If no page number parameter is provided, all results will be returned. By default the [AroFlo API](https://apidocs.aroflo.com/?version=latest#paging-in-aroflo-api) returns 500 records per request.

```cs
parameters.Add(new PageSizeParameter(10));
```

If you compare `currentpageresults` to `maxpageresults` you will know if you have to ask for the next page, incrementing pagenumber for the next query. If the value is less than the current maximum you have received the last set of data.

## Where

The `AndParameter` and `OrParameter` can be used to filter the request. The AroFlo API is still in development so not all "Zones" have a where filter that can be applied. 

```cs
parameters.Add(new ZoneParameter(AroFloZone.Users));
parameters.Add(new AndParameter("givennames", "steve", ComparisonOperator.Equal));
parameters.Add(new OrParameter("archived", "true", ComparisonOperator.Equal));
```

The above example would generate the following string.
`zone=users&where=and|givennames|=|steve&where=or|archived|=|true`

`WhereParameters` can also have sub parameters that can be used for more complex comparisons.

```cs
parameters.Add(new ZoneParameter(AroFloZone.Tasks));

var where1 = new AndParameter("clientname", "ClientA", ComparisonOperator.Equal);
where1.Parameters.Add(new OrParameter("clientname", "ClientB", ComparisonOperator.Equal));

parameters.Add(where1);
parameters.Add(new AndParameter("daterequested", "2017-12-01", ComparisonOperator.Equal));
```

The above example would generate the following string.
`zone=tasks&where=and|(|clientname|=|ClientA&where=or|clientname|=|ClientB|)&where=and|daterequested|=|2017-12-01`

## Order By

```cs
parameters.Add(new OrderParameter("givennames", SortOrder.Ascending));
```

# Documentation

No documentation exists. But feel free to contribute!

# Build

If you are running GitHub Desktop, you can clone this repository locally from
GitHub using the "Clone in Desktop" button from the AroFloSharp project page,
or run this command in your Git-enabled shell:

`git clone https://github.com/puppetsw/AroFloSharp`

If you are looking to contribute to the codebase, please ensure you have Visual
Studio 2022 installed - you can download the Community edition from
[here](https://visualstudio.microsoft.com/vs/)

`dotnet build AroFloSharp.Client`

# Contribute
Visit the [Contributor Guidelines](https://github.com/puppetsw/AroFloSharp/blob/master/CONTRIBUTING.md)
for more details. All contributors are expected to follow our
[Code of Conduct](https://github.com/puppetsw/AroFloSharp/blob/master/CODE_OF_CONDUCT.md).

# Copyright and License

Copyright 2022 (c) Scott Whitney
Licensed under the [MIT License](LICENSE.md)
