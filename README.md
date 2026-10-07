# Juit Jurisprudence .NET SDK

Cliente .NET moderno e fortemente tipado para busca de jurisprudências e download de artefatos pela API da Juit.

[![CI](https://github.com/loud-technology/loud-technology-juit-sdk/actions/workflows/dotnet.yml/badge.svg?branch=main)](https://github.com/loud-technology/loud-technology-juit-sdk/actions/workflows/dotnet.yml)
[![License: MIT](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
[![.NET 10](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet)](https://dotnet.microsoft.com/)

> [!NOTE]
> Este SDK comunitário é mantido pela loud-technology e gerado a partir do contrato OpenAPI da Juit. Não é um SDK oficial da Juit.

## Recursos

- Cobertura dos endpoints de busca de jurisprudências e download de artefatos.
- Autenticação HTTP Basic com credenciais explícitas ou variáveis de ambiente.
- Filtros, campos de busca, ordenação, UFs e demais valores enumerados fortemente tipados.
- Modelos nullable, validação por Data Annotations e serialização JSON source-generated.
- Downloads como `byte[]` ou `Stream`.
- Métodos assíncronos, cancelamento, respostas completas e exceções HTTP tipadas.
- Geração reproduzível com AutoSDK `0.34.6` e overrides OpenAPI determinísticos.

## Requisitos

- .NET 10 SDK ou posterior para compilar
- Credenciais de acesso à API da Juit

## Instalação

```bash
dotnet add package Juit.Jurisprudence
```

## Início rápido

Mantenha as credenciais fora do código-fonte:

```bash
export JUIT_USERNAME="your-client-id"
export JUIT_PASSWORD="your-client-secret"
```

Busque jurisprudências pelo título e pela ementa:

```csharp
using Loud.Technology.Juit.Jurisprudence.Sdk;

using var client = JuitJurisprudenceClient.CreateFromEnvironment();

var result = await client.GetJurisprudencesAsync(
    query: "dano moral",
    owner: "usuario@example.com",
    searchOn:
    [
        GetJurisprudencesSearchOnItem.Title,
        GetJurisprudencesSearchOnItem.Headnote,
    ],
    courtCode: ["TJSP"],
    processOriginState: [GetJurisprudencesProcessOriginStateItem.Sp]);

foreach (var jurisprudence in result.Items ?? [])
{
    Console.WriteLine($"{jurisprudence.Title} — {jurisprudence.JuitId}");
}
```

### Paginação

Reutilize o `SearchInfo.SearchId` e envie o `NextPageToken` retornado pela página anterior:

```csharp
var nextPage = await client.GetJurisprudencesAsync(
    query: "dano moral",
    owner: "usuario@example.com",
    searchOn: [GetJurisprudencesSearchOnItem.Title],
    searchId: result.SearchInfo?.SearchId,
    nextPageToken: result.NextPageToken);
```

### Download de artefato

```csharp
var record = result.Items!.First();
var artifact = record.Artifacts!.First();

await using var source = await client.DownloadJurisprudenceArtifactAsStreamAsync(
    juitId: record.JuitId!,
    owner: "usuario@example.com",
    filename: artifact.Filename!);
await using var destination = File.Create(artifact.Filename!);
await source.CopyToAsync(destination);
```

Use `DownloadJurisprudenceArtifactAsync` quando preferir receber um `byte[]`.

## Configuração do cliente

### Credenciais explícitas

```csharp
using var client = new JuitJurisprudenceClient(
    username: "your-client-id",
    password: "your-client-secret");
```

### `HttpClient` gerenciado pela aplicação

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

| Variável | Finalidade | Padrão |
|---|---|---|
| `JUIT_USERNAME` | Username/client ID do HTTP Basic | Obrigatória em `CreateFromEnvironment()` |
| `JUIT_PASSWORD` | Password/client secret do HTTP Basic | Obrigatória em `CreateFromEnvironment()` |
| `JUIT_BASE_URL` | Endpoint da API | `https://api.juit.io/v1/data-products/search` |

Nunca versione credenciais. Use variáveis de ambiente, .NET user secrets ou um secret manager.

## Superfície da API

| Método | Endpoint |
|---|---|
| `GetJurisprudencesAsync` | `GET /jurisprudence` |
| `GetJurisprudencesAsResponseAsync` | `GET /jurisprudence`, incluindo status e headers |
| `DownloadJurisprudenceArtifactAsync` | `GET /jurisprudence/{juit_id}/artifact`, como `byte[]` |
| `DownloadJurisprudenceArtifactAsStreamAsync` | Mesmo endpoint, como `Stream` |
| `DownloadJurisprudenceArtifactAsResponseAsync` | Mesmo endpoint, incluindo status e headers |

Todos os métodos aceitam `CancellationToken`. Respostas sem sucesso lançam `ApiException`; a hierarquia gerada também inclui exceções específicas para autenticação, autorização, validação, rate limit e falhas do servidor.

## Regenerar

O `juit-swagger.json` na raiz é a fonte do contrato:

```bash
cd src/libs/JuitJurisprudence
./generate.sh
```

O script fixa o AutoSDK em `0.34.6`, cria `openapi.json`, aplica correções estritamente voltadas à geração e substitui `Generated/`.

## Compilar e testar

```bash
dotnet restore Loud.Technology.Juit.Jurisprudence.Sdk.slnx
dotnet build Loud.Technology.Juit.Jurisprudence.Sdk.slnx --configuration Release --no-restore
dotnet test Loud.Technology.Juit.Jurisprudence.Sdk.slnx --configuration Release --no-build
```

Os testes de contrato não acessam a rede: validam URL, HTTP Basic, query strings, filtros tipados, desserialização, downloads binários e constraints dos modelos.

## Licença

Distribuído sob a [licença MIT](LICENSE).
