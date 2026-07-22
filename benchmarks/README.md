# Benchmarks

This project is configured for BenchmarkDotNet but intentionally contains no ready-made scenarios. Each benchmark should be written while reviewing its corresponding topic and should answer a concrete performance question.

Run it in Release mode:

```bash
dotnet run --project benchmarks/CodingPractice.Benchmarks -c Release
```

A benchmark should:

- compare equivalent behavior;
- use representative, parameterized inputs;
- keep data preparation outside the measured operation;
- state the hypothesis being tested;
- interpret execution time and allocations instead of merely copying numbers.
