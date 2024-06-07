using System;
public class BillingSupportHandler : TicketHandler
{
    public override void HandleTicket(Ticket ticket)
    {
        if (ticket.Type == "Billing")
        {
            Console.WriteLine($"Handling billing ticket: {ticket.Description}");
        }
        else
        {
            base.HandleTicket(ticket);
        }
    }
}
