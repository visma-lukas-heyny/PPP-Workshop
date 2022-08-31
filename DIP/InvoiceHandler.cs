using DIP.Abstractions;

namespace DIP;

public class InvoiceHandler : IInvoiceHandler
{
    private readonly BaseInvoiceReporter _reporter;

    public InvoiceHandler(BaseInvoiceReporter reporter)
    {
        _reporter = reporter;
    }

    public void PrintReport(IEnumerable<string> workData)
    {
        _reporter.PrintReport(_reporter.CreateReport(workData));
    }
    
    public IEnumerable<string> SetDoneWorkDataToInvoiced(string[] workData)
    {
        const string doneState = ": done";
        const string invoicedState = ": invoiced";
        var updatedWorkData = workData.Select(line => line.Replace(doneState, invoicedState));
        return updatedWorkData;
    }
}