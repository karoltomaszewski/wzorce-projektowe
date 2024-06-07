public abstract class TicketHandler : ITicketHandler
{
    private ITicketHandler _nextHandler;

    public void SetNext(ITicketHandler nextHandler)
    {
        _nextHandler = nextHandler;
    }

    public virtual void HandleTicket(Ticket ticket)
    {
        if (_nextHandler != null)
        {
            _nextHandler.HandleTicket(ticket);
        }
    }
}
