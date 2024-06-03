public interface IPizzaBuilder
{
    void SetCrust(string crust);
    void AddMeat(string meat);
    void AddCheese(string cheese);
    void AddVegetables(string vegetables);
    void AddSpices(string spices);
    Pizza GetPizza();
}