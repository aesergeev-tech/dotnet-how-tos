namespace DecoratorPattern;

public abstract class OrderDecorator : IOrder
{
    protected readonly IOrder _order;

    protected OrderDecorator(IOrder order)
    {
        _order = order;
    }

    public abstract decimal CalculateTotal();
}