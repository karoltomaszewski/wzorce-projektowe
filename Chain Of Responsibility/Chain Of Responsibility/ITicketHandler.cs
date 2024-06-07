public interface ITicketHandler
{
    void SetNext(ITicketHandler nextHandler);
    void HandleTicket(Ticket ticket);
}
