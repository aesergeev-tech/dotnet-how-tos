# Open/Closed Principle Examples in C#

This project contains practical, illustrative examples of the **Open/Closed Principle (OCP)** — the "O" in the SOLID acronym. The core idea of the principle is that software entities (classes, modules, functions) should be **open for extension, but closed for modification**.

Instead of dry theory, this repository demonstrates how to achieve OCP using three classic design patterns. Each pattern is implemented in a separate, self-contained project.

## Demonstrated Patterns

1.  **[Strategy Pattern](./StrategyPattern/)**
    *   **Use Case:** When you have a family of interchangeable algorithms or behaviors that can be selected at runtime.
    *   **Example:** A `PaymentProcessor` that can handle various payment methods (credit card, PayPal) without needing modification when a new method is added.

2.  **[Decorator Pattern](./DecoratorPattern/)**
    *   **Use Case:** When you need to add new responsibilities to objects dynamically and transparently.
    *   **Example:** An `Order` processing system where you can add extra options like gift wrapping or express shipping without altering the base `Order` class.

3.  **[Factory Method Pattern](./FactoryMethodPattern/)**
    *   **Use Case:** When a class cannot anticipate the class of objects it must create and delegates their creation to subclasses or a helper class.
    *   **Example:** A `ReportFactory` that can create different types of reports (`PDF`, `Excel`), where the client code does not need to know the concrete classes of the reports being created.

Explore each project to see the code and read more about how each pattern helps adhere to the Open/Closed Principle.