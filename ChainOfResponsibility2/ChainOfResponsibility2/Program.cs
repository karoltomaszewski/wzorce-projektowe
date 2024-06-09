internal class Program
{
    public static void Main(string[] args)
    {
        Logger infoLogger = new InfoLogger();
        Logger warningLogger = new WarningLogger();
        Logger errorLogger = new ErrorLogger();

        infoLogger.SetNextLogger(warningLogger);
        warningLogger.SetNextLogger(errorLogger);

        infoLogger.LogMessage("INFO", "To jest komunikat informacyjny.");
        infoLogger.LogMessage("WARNING", "To jest ostrzeżenie.");
        infoLogger.LogMessage("ERROR", "To jest błąd.");
    }
}