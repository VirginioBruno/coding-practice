# Coding Practice

Laboratório de algoritmos, estruturas de dados e desafios de programação em C# e .NET 10. O objetivo é registrar implementações compreendidas, testadas e documentadas — não apenas acumular soluções.

## Conteúdo atual

| Área | Implementações | Situação |
| --- | --- | --- |
| Inserção em arrays | início, posição e fim | concluído e testado |
| Busca | linear, binária iterativa e recursiva | concluído e testado |
| Ordenação | bubble, selection e insertion sort | concluído e testado |
| Estruturas de dados | array dinâmico | concluído e testado |
| Challenges | números primos, palíndromo, ordenação e strings | concluído e testado |
| Estruturas lineares, árvores e grafos | consulte o [`ROADMAP.md`](./ROADMAP.md) | planejado |

Os projetos são reunidos pela solução [`coding-practice.sln`](./coding-practice.sln). Os testes ficam centralizados em [`tests/CodingPractice.Tests`](./tests/CodingPractice.Tests).

## Requisitos

- .NET 10 SDK

## Comandos úteis

```bash
dotnet restore coding-practice.sln
dotnet format coding-practice.sln --verify-no-changes --no-restore
dotnet build coding-practice.sln --configuration Release --no-restore
dotnet test coding-practice.sln --configuration Release --no-build --no-restore
```

Para criar um benchmark durante o estudo de um tópico:

```bash
dotnet run --project benchmarks/CodingPractice.Benchmarks -c Release
```

## Método de estudo

- Use o [`guia de estudo`](./docs/STUDY_GUIDE.md) como fluxo de revisão.
- Copie o [`template de estudo`](./docs/STUDY_TEMPLATE.md) para documentar cada tópico.
- Atualize o [`roadmap`](./ROADMAP.md) somente quando a definição de pronto for atendida.

## Qualidade automatizada

O CI verifica formatação, padrões comuns de segredos, build sem warnings, 23 testes automatizados e cobertura mínima inicial de 40%. O Dependabot acompanha atualizações de pacotes NuGet e das GitHub Actions.

## Licença

Distribuído sob a licença MIT. Consulte [`LICENSE`](./LICENSE).
