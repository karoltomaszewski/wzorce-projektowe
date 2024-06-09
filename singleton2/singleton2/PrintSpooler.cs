using System;
using System.Collections.Generic;
public sealed class PrintSpooler
{
    private static readonly PrintSpooler instance = new PrintSpooler();
    private Queue<PrintJob> printQueue = new Queue<PrintJob>();

    private PrintSpooler() { }

    public static PrintSpooler Instance => instance;

    public void AddPrintJob(PrintJob job)
    {
        printQueue.Enqueue(job);
        Console.WriteLine($"Added {job}");
    }

    public void ProcessPrintJobs()
    {
        while (printQueue.Count > 0)
        {
            PrintJob job = printQueue.Dequeue();
            Console.WriteLine($"Processing {job}");
            // Simulate printing
            System.Threading.Thread.Sleep(1000);
        }
    }
}