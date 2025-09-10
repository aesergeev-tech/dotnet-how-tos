using StrategyPattern;
using StrategyPattern.Context;
using StrategyPattern.Strategies;

Console.WriteLine("--- Strategy Pattern Example ---");

// Using Credit Card
var creditCardProcessor = new PaymentProcessor(new CreditCardPaymentStrategy());
creditCardProcessor.ProcessPayment(100.50m);

// Using PayPal
var payPalProcessor = new PaymentProcessor(new PayPalPaymentStrategy());
payPalProcessor.ProcessPayment(55.75m);

// To add a new payment method, we would create a new class implementing IPaymentStrategy
// without modifying PaymentProcessor.
Console.WriteLine();