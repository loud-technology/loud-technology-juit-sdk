# Publicação de releases

Releases estáveis são produzidos a partir de tags semânticas e publicados no GitHub Packages e no NuGet.org.

## Configurar Trusted Publishing

No NuGet.org, crie uma política de Trusted Publishing para o proprietário do pacote `Juit.Jurisprudence` com os valores:

| Campo | Valor |
|---|---|
| Repository Owner | `loud-technology` |
| Repository | `loud-technology-juit-sdk` |
| Workflow File | `dotnet.yml` |
| Environment | `nuget-org` |

No GitHub, crie o environment `nuget-org` e configure a variável de Actions `NUGET_USER` com o username do perfil NuGet.org, não o e-mail. O workflow usa OIDC para obter uma chave temporária; nenhuma API key permanente precisa ser armazenada.

O GitHub Packages usa o `GITHUB_TOKEN` do próprio workflow com permissão `packages: write`.

## Publicar

Crie e envie uma tag semântica:

```bash
git tag v1.0.0
git push origin v1.0.0
```

O MinVer converte `v1.0.0` na versão `1.0.0`. O workflow compila e testa uma vez, cria `.nupkg` e `.snupkg`, e reutiliza os mesmos artefatos nos dois registries.

Builds sem tag geram versões de desenvolvimento, mas não publicam pacotes.
