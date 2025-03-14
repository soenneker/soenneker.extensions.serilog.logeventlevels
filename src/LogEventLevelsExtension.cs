using Microsoft.Extensions.Logging;
using Serilog.Events;

namespace Soenneker.Extensions.Serilog.LogEventLevels;

/// <summary>
/// A collection of helpful Serilog LogEventLevel extension methods
/// </summary>
public static class LogEventLevelsExtension
{
    /// <summary>
    /// Converts a <see cref="LogEventLevel"/> value to the equivalent <see cref="LogLevel"/> used by Microsoft logging.
    /// </summary>
    /// <param name="value">The <see cref="LogEventLevel"/> to convert.</param>
    /// <returns>
    /// A <see cref="LogLevel"/> equivalent to the given <see cref="LogEventLevel"/>.
    /// Returns <see cref="LogLevel.None"/> if the input value is unrecognized.
    /// </returns>
    public static LogLevel ToMicrosoftLogLevel(this LogEventLevel value)
    {
        return value switch
        {
            LogEventLevel.Verbose => LogLevel.Trace,
            LogEventLevel.Debug => LogLevel.Debug,
            LogEventLevel.Information => LogLevel.Information,
            LogEventLevel.Warning => LogLevel.Warning,
            LogEventLevel.Error => LogLevel.Error,
            LogEventLevel.Fatal => LogLevel.Critical,
            _ => LogLevel.None
        };
    }
}
