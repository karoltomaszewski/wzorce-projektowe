using System;

public class ErrorLogger : Logger
{
    protected override bool IsLogLevelEnabled(string level)
    {
        return level == "ERROR";
    }

    protected override void WriteMessage(string level, string message)
    {
        Console.WriteLine($"[{level}] {message}");
    }
}