public class Program
{
    public static void Main(string[] args)
    {
        INewLogger newLogger = new NewLogger();
        IOldLogger loggerAdapter = new LoggerAdapter(newLogger);

        MessageSystem system = new MessageSystem(loggerAdapter);
        system.Process();
    }
}