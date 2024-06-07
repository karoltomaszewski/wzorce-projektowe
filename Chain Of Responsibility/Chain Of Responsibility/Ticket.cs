public class Ticket
{
    public string Type { get; set; }
    public string Description { get; set; }

    public Ticket(string type, string description)
    {
        Type = type;
        Description = description;
    }
}
