using System;

public class InfoLogger : Logger
{
    protected override bool IsLogLevelEnabled(string level)
    {
        return level == "INFO";
    }

    protected override void WriteMessage(string level, string message)
    {
        Console.WriteLine($"[{level}] {message}");
    }
}