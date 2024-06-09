public class Program
{
    public static void Main()
    {
        PrintSpooler spooler = PrintSpooler.Instance;

        spooler.AddPrintJob(new PrintJob(1, "Document1.pdf"));
        spooler.AddPrintJob(new PrintJob(2, "Document2.docx"));

        spooler.ProcessPrintJobs();
    }
}