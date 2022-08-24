# AroFloSharp

The AroFloSharp library provides easy access to the [AroFlo](https://www.aroflo.com) API.

# Example
```cs
var options = new AroFloSharpOptions
{
    SecretKey = "",
    UEncode = "",
    PEncode = "",
    OrgEncode = ""
};

using (var client = new AroFloSharpClient(options))
{
    var projects = await client.GetProjectsAsync();
}
```


# Supported Platforms
* .NET Framework 4.6.1 or greater.

# Getting Started

AroFloSharp is a [AroFlo](https://wwww.aroflo.com) API client library for .NET and is available on NuGet:
`
dotnet add package AroFloSharp
`

# Documentation

No documentation exists as of yet. But feel free to contribute!

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
Visit the [Contributor Guidelines](https://github.com/puppetsw/AroFloSharp/blob/main/CONTRIBUTING.md)
for more details. All contributors are expected to follow our
[Code of Conduct](https://github.com/puppetsw/AroFloSharp/blob/main/CODE_OF_CONDUCT.md).

# Copyright and License

Copyright 2022 (c) Scott Whitney
Licensed under the [MIT License](LICENSE.md)
