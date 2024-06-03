public class ConcretePizzaBuilder : IPizzaBuilder
{
    private Pizza _pizza;

    public ConcretePizzaBuilder()
    {
        _pizza = new Pizza();
    }

    public void SetCrust(string crust)
    {
        _pizza.Crust = crust;
    }

    public void AddMeat(string meat)
    {
        _pizza.Meat = meat;
    }

    public void AddCheese(string cheese)
    {
        _pizza.Cheese = cheese;
    }

    public void AddVegetables(string vegetables)
    {
        _pizza.Vegetables = vegetables;
    }

    public void AddSpices(string spices)
    {
        _pizza.Spices = spices;
    }

    public Pizza GetPizza()
    {
        return _pizza;
    }
}
