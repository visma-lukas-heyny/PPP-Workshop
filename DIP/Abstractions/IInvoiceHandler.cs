namespace DIP.Abstractions;

internal interface IInvoiceHandler
{
    IEnumerable<string> SetDoneWorkDataToInvoiced(string[] workData);
}