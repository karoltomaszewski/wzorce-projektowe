public abstract class Logger
{
    protected Logger nextLogger;

    public void SetNextLogger(Logger nextLogger)
    {
        this.nextLogger = nextLogger;
    }

    public void LogMessage(string level, string message)
    {
        if (IsLogLevelEnabled(level))
        {
            WriteMessage(level, message);
        }

        if (nextLogger != null)
        {
            nextLogger.LogMessage(level, message);
        }
    }

    protected abstract bool IsLogLevelEnabled(string level);
    protected abstract void WriteMessage(string level, string message);
}