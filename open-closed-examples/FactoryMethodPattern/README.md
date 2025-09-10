# Factory Method Pattern

This project demonstrates the **Factory Method Pattern**.

The Factory Method Pattern defines an interface for creating an object, but lets subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.

## Example

In this example:
- `IReport` is the common interface for the products (reports).
- `PdfReport` and `ExcelReport` are concrete products.
- `ReportFactory` acts as the creator, providing a method `CreateReport` to produce report objects based on a given type.

This allows the client code to request a report by type without being tightly coupled to the concrete report classes. To add a new report format, you would create a new class implementing `IReport` and register it in the factory, without changing the client code.