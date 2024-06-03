public class Director
{
    private IPizzaBuilder _pizzaBuilder;

    public Director(IPizzaBuilder pizzaBuilder)
    {
        _pizzaBuilder = pizzaBuilder;
    }

    public void BuildMargheritaPizza()
    {
        _pizzaBuilder.SetCrust("Thin Crust");
        _pizzaBuilder.AddCheese("Mozzarella");
        _pizzaBuilder.AddVegetables("Tomatoes, Basil");
        _pizzaBuilder.AddSpices("Oregano");
    }

    public void BuildPepperoniPizza()
    {
        _pizzaBuilder.SetCrust("Regular Crust");
        _pizzaBuilder.AddMeat("Pepperoni");
        _pizzaBuilder.AddCheese("Mozzarella");
        _pizzaBuilder.AddVegetables("Tomatoes");
        _pizzaBuilder.AddSpices("Oregano, Chili Flakes");
    }
}
