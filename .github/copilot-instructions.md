# Copilot Review Instructions

When reviewing pull requests in this repository, prioritize:

1. Build safety for .NET 10 projects (`*.csproj` target `net10.0`).
2. Logic bugs and potential runtime exceptions.
3. Breaking changes in public method signatures or behavior.
4. Input handling and basic defensive checks.
5. Clear naming and maintainable code structure.

Review style:

- Give concise, actionable comments.
- Prefer concrete fix suggestions when possible.
- Avoid style-only comments unless they impact readability or maintenance.
