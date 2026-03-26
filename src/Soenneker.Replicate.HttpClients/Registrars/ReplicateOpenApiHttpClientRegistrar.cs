using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Replicate.HttpClients.Abstract;
using Soenneker.Utils.HttpClientCache.Registrar;

namespace Soenneker.Replicate.HttpClients.Registrars;

/// <summary>
/// Registers the OpenAPI HttpClient wrapper for dependency injection.
/// </summary>
public static class ReplicateOpenApiHttpClientRegistrar
{
    /// <summary>
    /// Adds <see cref="ReplicateOpenApiHttpClient"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddReplicateOpenApiHttpClientAsSingleton(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddSingleton<IReplicateOpenApiHttpClient, ReplicateOpenApiHttpClient>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="ReplicateOpenApiHttpClient"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddReplicateOpenApiHttpClientAsScoped(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddScoped<IReplicateOpenApiHttpClient, ReplicateOpenApiHttpClient>();

        return services;
    }
}
