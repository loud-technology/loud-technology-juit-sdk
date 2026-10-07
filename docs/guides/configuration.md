# Configuração do cliente

## Configuração por ambiente

```bash
export JUIT_USERNAME="your-client-id"
export JUIT_PASSWORD="your-client-secret"
export JUIT_BASE_URL="https://api.juit.io/v1/data-products/search"
```

```csharp
using Loud.Technology.Juit.Jurisprudence.Sdk;

using var client = JuitJurisprudenceClient.CreateFromEnvironment();
```

`CreateFromEnvironment()` lança `InvalidOperationException` quando uma credencial está ausente ou a URL configurada é inválida.

## Configuração explícita

```csharp
using var client = new JuitJurisprudenceClient(
    username: "your-client-id",
    password: "your-client-secret",
    baseUri: new Uri("https://api.juit.io/v1/data-products/search"));
```

O cliente envia `Authorization: Basic <base64(username:password)>`.

## Transporte gerenciado pela aplicação

```csharp
using var httpClient = new HttpClient
{
    Timeout = TimeSpan.FromSeconds(30),
};

using var client = new JuitJurisprudenceClient(
    username: Environment.GetEnvironmentVariable("JUIT_USERNAME")!,
    password: Environment.GetEnvironmentVariable("JUIT_PASSWORD")!,
    httpClient: httpClient,
    disposeHttpClient: false);
```

Use `disposeHttpClient: false` quando injeção de dependência ou outra parte da aplicação controlar o ciclo de vida do `HttpClient`.

## Opções por requisição

Os métodos gerados aceitam `AutoSDKRequestOptions`, permitindo headers e query parameters adicionais, timeout, retries e buffering de resposta. Não adicione credenciais por essas opções; use o construtor para manter a autenticação consistente.
