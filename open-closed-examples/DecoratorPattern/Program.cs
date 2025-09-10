using DecoratorPattern;

Console.WriteLine("--- Decorator Pattern Example ---");

IOrder order = new SimpleOrder(100);
Console.WriteLine($"Simple order total: {order.CalculateTotal():C}");

// Add gift wrap
order = new GiftWrapDecorator(order);
Console.WriteLine($"Order with gift wrap total: {order.CalculateTotal():C}");

// Add express shipping
order = new ExpressShippingDecorator(order);
Console.WriteLine($"Order with gift wrap and express shipping total: {order.CalculateTotal():C}");

// To add new options, we can create new decorators without changing existing classes.
Console.WriteLine();