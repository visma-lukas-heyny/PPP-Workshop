using DIP.Abstractions;

namespace DIP;

public class BaseInvoiceReporter
{
    protected readonly IUiClient UiClient;

    public BaseInvoiceReporter(IUiClient uiClient)
    {
        UiClient = uiClient;
    }

    public virtual IEnumerable<string> CreateReport(IEnumerable<string> workData)
    {
        const string billableState = "done";
    
        return workData.Where(line => line.EndsWith(billableState));
    }

    public virtual void PrintReport(IEnumerable<string> reportData) 
    {
        const string invoiceReportHeader = "Send invoice for:";
    
        UiClient.Output(invoiceReportHeader);
        reportData.ToList().ForEach(UiClient.Output);
    }
}