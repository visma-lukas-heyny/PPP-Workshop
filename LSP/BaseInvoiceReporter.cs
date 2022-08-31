using LSP.Abstractions;

namespace LSP;

public class BaseInvoiceReporter
{
    private readonly IUiClient _uiClient;

    public BaseInvoiceReporter(IUiClient uiClient)
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