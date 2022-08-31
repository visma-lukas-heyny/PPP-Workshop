using LSP;
using NUnit.Framework;

namespace LSP_Tests;

public abstract class InvoiceReporterTest
{
    protected abstract BaseInvoiceReporter GetSut();

    [TestCase("something: done")]
    public void CreatingReport_WithWorkData_DoesNotThrow(string workData)
    {
        var sut = GetSut();

        void Act() => _ = sut.CreateReport(workData.Split(";")).ToArray();

        Assert.DoesNotThrow(Act);
    }
}

internal class BaseInvoiceReporterTest : InvoiceReporterTest
{
    protected override BaseInvoiceReporter GetSut()
    {
        return new BaseInvoiceReporter(new ConsoleUiClientStub());
    }
}