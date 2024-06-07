using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var technicalHandler = new TechnicalSupportHandler();
        var billingHandler = new BillingSupportHandler();
        var generalHandler = new GeneralSupportHandler();

        technicalHandler.SetNext(billingHandler);
        billingHandler.SetNext(generalHandler);

        var tickets = new List<Ticket>
        {
            new Ticket("Technical", "Cannot connect to the internet."),
            new Ticket("Billing", "Incorrect charge on my account."),
            new Ticket("General", "What are your working hours?"),
            new Ticket("Technical", "Printer is not working."),
            new Ticket("Billing", "Need a copy of my last invoice."),
            new Ticket("General", "How to reset my password?")
        };

        foreach (var ticket in tickets)
        {
            technicalHandler.HandleTicket(ticket);
        }
    }
}
