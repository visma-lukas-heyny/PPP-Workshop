namespace OCP;

public class InvoiceReporter
{
    private readonly ConsoleUiClient _uiClient;

    public InvoiceReporter(ConsoleUiClient uiClient)
    {
        _uiClient = uiClient;
    }

    public IEnumerable<string> CreateReport(IEnumerable<string> workData)
    {
        const string billableState = "done";
    
        return workData.Where(line => line.EndsWith(billableState));
    }

    public void PrintReport(IEnumerable<string> reportData) 
    {
        const string invoiceReportHeader = "Send invoice for:";
    
        _uiClient.Output(invoiceReportHeader);
        reportData.ToList().ForEach(_uiClient.Output);
    }
}