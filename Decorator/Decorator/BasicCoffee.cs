public class BasicCoffee : ICoffee
{
    public string GetDescription()
    {
        return "Basic Coffee";
    }

    public double GetCost()
    {
        return 5.0;
    }
}