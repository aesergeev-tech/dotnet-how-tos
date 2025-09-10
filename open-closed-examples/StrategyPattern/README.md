# Strategy Pattern

This project demonstrates the **Strategy Pattern**.

The Strategy Pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it.

## Example

In this example:
- `IPaymentStrategy` is the common interface for all strategies.
- `CreditCardPaymentStrategy` and `PayPalPaymentStrategy` are concrete implementations of the payment algorithms.
- `PaymentProcessor` is the context class that uses a payment strategy.

This setup allows adding new payment methods (e.g., Bitcoin) by simply creating a new class that implements `IPaymentStrategy` without modifying the `PaymentProcessor` class, thus adhering to the Open/Closed Principle.