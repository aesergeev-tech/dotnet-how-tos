namespace StrategyPattern.Strategies;

public interface IPaymentStrategy
{
    void ProcessPayment(decimal amount);
}