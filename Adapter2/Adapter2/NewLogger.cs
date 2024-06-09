using System;

public class NewLogger : INewLogger
{
    public void LogInfo(string message)
    {
        Console.WriteLine("Info: " + message);
    }

    public void LogWarn(string message)
    {
        Console.WriteLine("Warning: " + message);
    }

    public void LogDebug(string message)
    {
        Console.WriteLine("Debug: " + message);
    }
}
