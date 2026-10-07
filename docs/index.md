# Juit Jurisprudence .NET SDK

Cliente .NET fortemente tipado para a API de busca de jurisprudências da Juit, mantido pela loud-technology.

## Destaques

- Busca de jurisprudências com filtros e ordenação tipados.
- Paginação por `search_id` e `next_page_token`.
- Download de artefatos como bytes ou stream.
- HTTP Basic, APIs assíncronas, cancellation e exceções HTTP tipadas.
- Geração reproduzível a partir do contrato OpenAPI versionado.

!!! note
    Este é um SDK comunitário e não oficial da Juit.

## Primeira consulta

```csharp
using Loud.Technology.Juit.Jurisprudence.Sdk;

using var client = JuitJurisprudenceClient.CreateFromEnvironment();
var result = await client.GetJurisprudencesAsync(
    query: "dano moral",
    owner: "usuario@example.com",
    searchOn: [GetJurisprudencesSearchOnItem.Title]);
```

Continue em [Primeiros passos](getting-started.md).
