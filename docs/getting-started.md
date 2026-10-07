# Primeiros passos

## 1. Instale

```bash
dotnet add package Juit.Jurisprudence
```

O SDK tem como alvo .NET 10.

## 2. Configure as credenciais

=== "macOS e Linux"

    ```bash
    export JUIT_USERNAME="your-client-id"
    export JUIT_PASSWORD="your-client-secret"
    ```

=== "PowerShell"

    ```powershell
    $env:JUIT_USERNAME = "your-client-id"
    $env:JUIT_PASSWORD = "your-client-secret"
    ```

As credenciais são enviadas com HTTP Basic em todas as requisições. Nunca versione credenciais reais.

## 3. Consulte jurisprudências

```csharp
using Loud.Technology.Juit.Jurisprudence.Sdk;

using var client = JuitJurisprudenceClient.CreateFromEnvironment();
var result = await client.GetJurisprudencesAsync(
    query: "responsabilidade civil",
    owner: "usuario@example.com",
    searchOn:
    [
        GetJurisprudencesSearchOnItem.Title,
        GetJurisprudencesSearchOnItem.Headnote,
        GetJurisprudencesSearchOnItem.FullText,
    ],
    orderDate: ["$gte20240101"],
    degree: [GetJurisprudencesDegreeItem.TribunalSuperior]);
```

Filtros de data aceitam `YYYYMMDD` e os prefixos `$gt`, `$gte`, `$lt` e `$lte` definidos no contrato Juit.

## 4. Percorra páginas

```csharp
var next = await client.GetJurisprudencesAsync(
    query: "responsabilidade civil",
    owner: "usuario@example.com",
    searchOn: [GetJurisprudencesSearchOnItem.Title],
    searchId: result.SearchInfo?.SearchId,
    nextPageToken: result.NextPageToken);
```

Não informe `searchId` nem `nextPageToken` na primeira consulta.

## 5. Baixe um artefato

```csharp
var jurisprudence = result.Items!.First();
var artifact = jurisprudence.Artifacts!.First();

byte[] content = await client.DownloadJurisprudenceArtifactAsync(
    juitId: jurisprudence.JuitId!,
    owner: "usuario@example.com",
    filename: artifact.Filename!);

await File.WriteAllBytesAsync(artifact.Filename!, content);
```

Para arquivos grandes, prefira `DownloadJurisprudenceArtifactAsStreamAsync`.

## Erros e cancelamento

```csharp
using var timeout = new CancellationTokenSource(TimeSpan.FromSeconds(30));

try
{
    var result = await client.GetJurisprudencesAsync(
        query: "dano moral",
        owner: "usuario@example.com",
        searchOn: [GetJurisprudencesSearchOnItem.Headnote],
        cancellationToken: timeout.Token);
}
catch (AuthenticationException exception)
{
    Console.Error.WriteLine($"Credenciais rejeitadas: {exception.Message}");
}
catch (ApiException exception)
{
    Console.Error.WriteLine($"A requisição falhou: {exception.Message}");
}
```
