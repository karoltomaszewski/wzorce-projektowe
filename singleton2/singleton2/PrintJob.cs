public class PrintJob
{
    public int Id { get; set; }
    public string DocumentName { get; set; }

    public PrintJob(int id, string documentName)
    {
        Id = id;
        DocumentName = documentName;
    }

    public override string ToString()
    {
        return $"PrintJob ID: {Id}, Document: {DocumentName}";
    }
}