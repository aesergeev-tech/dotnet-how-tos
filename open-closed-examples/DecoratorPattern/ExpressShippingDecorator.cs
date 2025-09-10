namespace DecoratorPattern;

public class ExpressShippingDecorator : OrderDecorator
{
    public ExpressShippingDecorator(IOrder order) : base(order) { }

    public override decimal CalculateTotal()
    {
        return _order.CalculateTotal() + 15.0m; // +$15 for express shipping
    }
}