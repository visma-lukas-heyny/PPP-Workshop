using System.Globalization;
using DIP.Abstractions;

namespace DIP;

public class InvoiceAmountAverageReporter : BaseInvoiceReporter
{
    private readonly decimal _totalInvoiceAmount;

    public InvoiceAmountAverageReporter(decimal totalInvoiceAmount, IUiClient uiClient) : base(uiClient)
    {
        _totalInvoiceAmount = totalInvoiceAmount;
    }

    public override IEnumerable<string> CreateReport(IEnumerable<string> workData)
    {
        var averageInvoiceAmount =  _totalInvoiceAmount / base.CreateReport(workData).ToArray().Length;
        
        yield return averageInvoiceAmount.ToString(CultureInfo.InvariantCulture);
    }

    public override void PrintReport(IEnumerable<string> reportData)
    {
        const string invoiceReportHeader = "Average invoice amount:";
    
        UiClient.Output(invoiceReportHeader);
        reportData.ToList().ForEach(UiClient.Output);
    }
}