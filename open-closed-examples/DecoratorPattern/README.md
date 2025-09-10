# Decorator Pattern

This project demonstrates the **Decorator Pattern**.

The Decorator Pattern allows behavior to be added to an individual object, dynamically, without affecting the behavior of other objects from the same class. The decorator pattern is often useful for adhering to the Single Responsibility Principle, as it allows functionality to be divided between classes with unique areas of concern.

## Example

In this example:
- `IOrder` is the component interface.
- `SimpleOrder` is a concrete component that can be decorated.
- `OrderDecorator` is the abstract base class for decorators.
- `GiftWrapDecorator` and `ExpressShippingDecorator` are concrete decorators that add new functionality (and cost) to the order.

This structure allows for flexibly combining different order options (like gift wrapping and express shipping) without creating a complex class hierarchy for every possible combination.