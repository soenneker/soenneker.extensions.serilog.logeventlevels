using Soenneker.Tests.HostedUnit;

namespace Soenneker.Extensions.Serilog.LogEventLevels.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class LogEventLevelsExtensionTests : HostedUnitTest
{
    public LogEventLevelsExtensionTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {
    }
}