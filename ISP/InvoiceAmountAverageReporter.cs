using System.Globalization;
using ISP.Abstractions;

namespace ISP;

public class InvoiceAmountAverageReporter : BaseInvoiceReporter
{
    private readonly decimal _totalInvoiceAmount;

    public InvoiceAmountAverageReporter(decimal totalInvoiceAmount, IUiClient uiClient) : base(uiClient)
    {
        _totalInvoiceAmount = totalInvoiceAmount;
    }

    public override IEnumerable<string> CreateReport(IEnumerable<string> workData)
    {
        var report = base.CreateReport(workData).ToArray();

        if (report.Length != 0)
        {
            var averageInvoiceAmount =  _totalInvoiceAmount / report.Length;
            yield return averageInvoiceAmount.ToString(CultureInfo.InvariantCulture);
        }
        else
        {
            yield return "Infinite";
        }
    }

    public override void PrintReport(IEnumerable<string> reportData)
    {
        const string invoiceReportHeader = "Average invoice amount:";
    
        UiClient.Output(invoiceReportHeader);
        reportData.ToList().ForEach(UiClient.Output);
    }
}