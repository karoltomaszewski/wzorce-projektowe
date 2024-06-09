using System;

public class WarningLogger : Logger
{
    protected override bool IsLogLevelEnabled(string level)
    {
        return level == "WARNING";
    }

    protected override void WriteMessage(string level, string message)
    {
        Console.WriteLine($"[{level}] {message}");
    }
}