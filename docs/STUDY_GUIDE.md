# Study guide

Use this workflow to review or implement each topic without turning the repository into a collection of copied solutions.

1. Write the contract: inputs, outputs, errors, and invariants.
2. Work through a small example by hand.
3. Implement the first version without premature optimization.
4. Write tests for boundaries, empty inputs, duplicates, and missing values.
5. Calculate time and space complexity.
6. Compare the implementation with the equivalent .NET API, when available.
7. Refactor names and responsibilities without changing behavior.
8. Run the build, tests, coverage checks, and relevant benchmarks.
9. Complete the study template and update the roadmap.

## Review questions

- Which invariant must remain true throughout execution?
- What is the worst case, and what causes it?
- Does the implementation support empty collections, duplicate values, and `null`?
- Is there a difference between amortized complexity and per-operation complexity?
- Which alternative would be preferable in production code?
- How would I explain the solution in five minutes during an interview?
