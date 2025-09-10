namespace StrategyPattern;

public interface IPaymentStrategy
{
    void ProcessPayment(decimal amount);
}