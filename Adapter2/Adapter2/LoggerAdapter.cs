public class LoggerAdapter : IOldLogger
{
    private readonly INewLogger _newLogger;

    public LoggerAdapter(INewLogger newLogger)
    {
        _newLogger = newLogger;
    }

    public void LogMessage(string message)
    {
        _newLogger.LogInfo(message);
    }

    public void LogError(string message)
    {
        _newLogger.LogWarn(message);
    }

    public void LogVerbose(string message)
    {
        _newLogger.LogDebug(message);
    }
}