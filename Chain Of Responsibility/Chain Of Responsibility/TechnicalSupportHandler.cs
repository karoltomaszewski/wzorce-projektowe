using System;
public class TechnicalSupportHandler : TicketHandler
{
    public override void HandleTicket(Ticket ticket)
    {
        if (ticket.Type == "Technical")
        {
            Console.WriteLine($"Handling technical ticket: {ticket.Description}");
        }
        else
        {
            base.HandleTicket(ticket);
        }
    }
}
