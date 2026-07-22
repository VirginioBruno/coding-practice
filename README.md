# Coding Practice

Algorithms, data structures, and coding challenges in C# and .NET 10. The goal is to document implementations that are understood, tested, and explained—not merely to accumulate solutions.

## Current content

| Area | Implementations | Status |
| --- | --- | --- |
| Array insertion | start, arbitrary position, and end | completed and tested |
| Search | linear, iterative binary, and recursive binary search | completed and tested |
| Sorting | bubble, selection, and insertion sort | completed and tested |
| Data structures | dynamic array | completed and tested |
| Challenges | prime numbers, palindromes, sorting, and strings | completed and tested |
| Linear structures, trees, and graphs | see [`ROADMAP.md`](./ROADMAP.md) | planned |

The projects are grouped in [`coding-practice.sln`](./coding-practice.sln), with tests centralized in [`tests/CodingPractice.Tests`](./tests/CodingPractice.Tests).

## Requirements

- .NET 10 SDK

## Useful commands

```bash
dotnet restore coding-practice.sln
dotnet format coding-practice.sln --verify-no-changes --no-restore
dotnet build coding-practice.sln --configuration Release --no-restore
dotnet test coding-practice.sln --configuration Release --no-build --no-restore
```

To create a benchmark while studying a topic:

```bash
dotnet run --project benchmarks/CodingPractice.Benchmarks -c Release
```

## Study workflow

- Follow the [`study guide`](./docs/STUDY_GUIDE.md) during each review.
- Copy the [`study template`](./docs/STUDY_TEMPLATE.md) to document each topic.
- Update the [`roadmap`](./ROADMAP.md) only after meeting the definition of done.

## Automated quality checks

CI checks formatting, common secret patterns, warning-free builds, 23 automated tests, and an initial minimum line coverage of 40%. Dependabot monitors NuGet packages and GitHub Actions for updates.

## License

Distributed under the MIT License. See [`LICENSE`](./LICENSE).
