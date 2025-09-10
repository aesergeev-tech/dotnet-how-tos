# .NET How-Tos and Examples

This repository is a collection of small, focused .NET projects designed to demonstrate various tools, patterns, and best practices in the .NET ecosystem. Each project is self-contained and provides a clear, concise example of a specific concept.

## Projects

Here's a list of the projects currently available in this repository:

### 1. Feature Flags

-   **Location:** [`feature-flags/`](./feature-flags/)
-   **Description:** A minimal demonstration of how to set up and use feature flags in a .NET application using the `Microsoft.FeatureManagement.AspNetCore` library. This project shows how to toggle features on and off through configuration.

### 2. Indexer Benchmark

-   **Location:** [`indexer-benchmark/`](./indexer-benchmark/)
-   **Description:** A collection of benchmarks using `BenchmarkDotNet` to compare the performance of different ways to accomplish common tasks in .NET. Examples include comparing `First()` vs. indexer `[0]` for accessing the first element of a collection, `MinBy` vs `OrderBy().First()`, and various string concatenation methods.

### 3. Open/Closed Principle Examples

-   **Location:** [`open-closed-examples/`](./open-closed-examples/)
-   **Description:** This project provides practical examples of the Open/Closed Principle, one of the five SOLID principles of object-oriented design. It demonstrates how software entities (classes, modules, functions, etc.) should be open for extension but closed for modification.
-   **Patterns demonstrated:**
    -   **Strategy Pattern:** [`StrategyPattern/`](./open-closed-examples/StrategyPattern/)
    -   **Decorator Pattern:** [`DecoratorPattern/`](./open-closed-examples/DecoratorPattern/)
    -   **Factory Method Pattern:** [`FactoryMethodPattern/`](./open-closed-examples/FactoryMethodPattern/)
