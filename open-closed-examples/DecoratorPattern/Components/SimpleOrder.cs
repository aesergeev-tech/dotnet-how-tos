namespace DecoratorPattern.Components;

public class SimpleOrder : IOrder
{
    private readonly decimal _price;

    public SimpleOrder(decimal price)
    {
        _price = price;
    }

    public decimal CalculateTotal() => _price;
}