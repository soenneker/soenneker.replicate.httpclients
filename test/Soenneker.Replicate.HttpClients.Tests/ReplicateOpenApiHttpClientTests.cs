using Soenneker.Replicate.HttpClients.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Replicate.HttpClients.Tests;

[Collection("Collection")]
public sealed class ReplicateOpenApiHttpClientTests : FixturedUnitTest
{
    private readonly IReplicateOpenApiHttpClient _httpclient;

    public ReplicateOpenApiHttpClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _httpclient = Resolve<IReplicateOpenApiHttpClient>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
