using System;

public class Client
{
    public Client()
    {
        IPizzaBuilder pizzaBuilder = new ConcretePizzaBuilder();
        Director director = new Director(pizzaBuilder);

        director.BuildMargheritaPizza();
        Pizza margheritaPizza = pizzaBuilder.GetPizza();
        Console.WriteLine(margheritaPizza.ToString());

        pizzaBuilder = new ConcretePizzaBuilder();
        director = new Director(pizzaBuilder);

        director.BuildPepperoniPizza();
        Pizza pepperoniPizza = pizzaBuilder.GetPizza();
        Console.WriteLine(pepperoniPizza.ToString());
    }
}
