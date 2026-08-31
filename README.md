[![](https://img.shields.io/nuget/v/soenneker.replicate.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.replicate.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.replicate.httpclients/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.replicate.httpclients/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.replicate.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.replicate.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.replicate.httpclients/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.replicate.httpclients/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Replicate.HttpClients

Provides a cached `HttpClient` for Replicate models, predictions, deployments, trainings, hardware, account details, and webhook secrets.

## Installation

```bash
dotnet add package Soenneker.Replicate.HttpClients
```

## Configuration

```json
{
  "Replicate": {
    "ApiKey": "your-replicate-api-token"
  }
}
```

## Usage

```csharp
using Soenneker.Replicate.HttpClients.Abstract;
using Soenneker.Replicate.HttpClients.Registrars;

services.AddReplicateOpenApiHttpClientAsSingleton();

public sealed class ReplicateAccountReader
{
    private readonly IReplicateOpenApiHttpClient _replicate;

    public ReplicateAccountReader(IReplicateOpenApiHttpClient replicate)
    {
        _replicate = replicate;
    }

    public async Task<string> GetAccount(CancellationToken cancellationToken)
    {
        HttpClient client = await _replicate.Get(cancellationToken);
        return await client.GetStringAsync("account", cancellationToken);
    }
}
```

The provider uses `https://api.replicate.com/v1/` and sends the token as `Authorization: Bearer <token>`. `Replicate:ClientBaseUrl`, `Replicate:AuthHeaderName`, and `Replicate:AuthHeaderValueTemplate` can override those defaults for a proxy or compatible service; use `{token}` in the value template where the configured token should be inserted.
