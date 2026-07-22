# Benchmarks

Este projeto está preparado para benchmarks com BenchmarkDotNet, mas não contém cenários prontos. Cada benchmark deve ser escrito durante a revisão do tópico correspondente, quando houver uma pergunta concreta de desempenho.

Execute em modo Release:

```bash
dotnet run --project benchmarks/CodingPractice.Benchmarks -c Release
```

Um benchmark deve:

- comparar comportamentos equivalentes;
- usar entradas representativas e parametrizadas;
- evitar incluir a preparação dos dados na medição;
- registrar a hipótese que está sendo verificada;
- interpretar tempo e alocações, não apenas copiar números.
