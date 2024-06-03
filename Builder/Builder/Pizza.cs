public class Pizza
{
    public string Crust { get; set; }
    public string Meat { get; set; }
    public string Cheese { get; set; }
    public string Vegetables { get; set; }
    public string Spices { get; set; }

    public override string ToString()
    {
        return $"Pizza with: Crust = {Crust}, Meat = {Meat}, Cheese = {Cheese}, Vegetables = {Vegetables}, Spices = {Spices}";
    }
}
