public class MessageSystem
{
    private readonly IOldLogger _logger;

    public MessageSystem(IOldLogger logger)
    {
        _logger = logger;
    }

    public void Process()
    {
        _logger.LogMessage("Processing started.");
        _logger.LogError("An error occurred.");
        _logger.LogVerbose("Processing finished.");
    }
}