using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace Soenneker.Replicate.HttpClients.Abstract;

/// <summary>
/// Provides an authenticated HTTP client for the Replicate API.
/// </summary>
public interface IReplicateOpenApiHttpClient : IDisposable, IAsyncDisposable
{
    /// <summary>
    /// Gets the cached client owned by this provider.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A task containing the result of the operation.</returns>
    ValueTask<HttpClient> Get(CancellationToken cancellationToken = default);

    /// <summary>
    /// Releases the HTTP client owned by this provider.
    /// </summary>
    new void Dispose();

    /// <summary>
    /// Asynchronously releases the HTTP client owned by this provider.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    new ValueTask DisposeAsync();
}
