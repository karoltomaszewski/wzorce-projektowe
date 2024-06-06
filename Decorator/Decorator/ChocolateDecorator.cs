public class ChocolateDecorator : CoffeeDecorator
{
    public ChocolateDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return _coffee.GetDescription() + ", Chocolate";
    }

    public override double GetCost()
    {
        return _coffee.GetCost() + 2.0;
    }
}