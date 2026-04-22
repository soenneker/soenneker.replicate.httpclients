using Soenneker.Replicate.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Replicate.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class ReplicateOpenApiHttpClientTests : HostedUnitTest
{
    private readonly IReplicateOpenApiHttpClient _httpclient;

    public ReplicateOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<IReplicateOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
