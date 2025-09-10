using DecoratorPattern.Components;

namespace DecoratorPattern.Decorators;

public abstract class OrderDecorator : IOrder
{
    protected readonly IOrder _order;

    protected OrderDecorator(IOrder order)
    {
        _order = order;
    }

    public abstract decimal CalculateTotal();
}