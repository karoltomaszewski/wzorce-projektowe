﻿public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return _coffee.GetDescription() + ", Milk";
    }

    public override double GetCost()
    {
        return _coffee.GetCost() + 1.5;
    }
}