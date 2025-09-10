using DecoratorPattern.Components;

namespace DecoratorPattern.Decorators;

public class GiftWrapDecorator : OrderDecorator
{
    public GiftWrapDecorator(IOrder order) : base(order) { }

    public override decimal CalculateTotal()
    {
        return _order.CalculateTotal() + 5.0m; // +$5 for gift wrap
    }
}