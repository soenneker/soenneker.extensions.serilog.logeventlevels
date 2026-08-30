[![](https://img.shields.io/nuget/v/soenneker.extensions.serilog.logeventlevels.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.serilog.logeventlevels/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.serilog.logeventlevels/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.serilog.logeventlevels/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.extensions.serilog.logeventlevels.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.serilog.logeventlevels/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.serilog.logeventlevels/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.serilog.logeventlevels/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.Serilog.LogEventLevels
Maps Serilog event levels to Microsoft logging levels and compact display prefixes.

## Installation

```bash
dotnet add package Soenneker.Extensions.Serilog.LogEventLevels
```

## Convert to Microsoft logging

```csharp
using Soenneker.Extensions.Serilog.LogEventLevels;

LogLevel microsoftLevel = LogEventLevel.Fatal.ToMicrosoftLogLevel();
// LogLevel.Critical
```

The mappings are:

| Serilog | Microsoft |
|---|---|
| `Verbose` | `Trace` |
| `Debug` | `Debug` |
| `Information` | `Information` |
| `Warning` | `Warning` |
| `Error` | `Error` |
| `Fatal` | `Critical` |

An undefined `LogEventLevel` value maps to `LogLevel.None`, which typically disables output rather than choosing a fallback severity.

## Create compact prefixes

```csharp
string prefix = LogEventLevel.Warning.ToShortLevelPrefix(); // "WARN"
```

Defined levels map to `VERB`, `DBUG`, `INFO`, `WARN`, `EROR`, and `FATL`. These spellings match compact log-display conventions; `EROR` is intentionally four characters.

An undefined enum value falls back to its `ToString()` representation converted to invariant uppercase. That fallback is not guaranteed to be four characters.
