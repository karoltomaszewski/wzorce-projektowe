using System;

public class GeneralSupportHandler : TicketHandler
{
    public override void HandleTicket(Ticket ticket)
    {
        if (ticket.Type == "General")
        {
            Console.WriteLine($"Handling general ticket: {ticket.Description}");
        }
        else
        {
            base.HandleTicket(ticket);
        }
    }
}
