using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Extensions.Serilog.LogEventLevels.Tests;

[Collection("Collection")]
public class LogEventLevelsExtensionTests : FixturedUnitTest
{
    public LogEventLevelsExtensionTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {
    }
}