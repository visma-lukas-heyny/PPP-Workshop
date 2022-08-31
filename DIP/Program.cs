using DIP;
using DIP.Abstractions;

// MyPSA


var uiClient = new ConsoleUiClient();
var authenticator = new UserPasswordAuthenticator(uiClient);

IWorkDataQueryRepository workDataQueryRepository = new CachingWorkDataRepositoryDecorator(new WorkDataFileRepository());
IWorkDataCommandRepository workDataCommandRepository = new WorkDataFileRepository();

var reporter = new BaseInvoiceReporter(uiClient);
var invoiceHandler = new InvoiceHandler(reporter);

authenticator.RequireAuthentication();

var workData = (await workDataQueryRepository.GetWorkDataAsync()).ToArray();

invoiceHandler.PrintReport(workData);

var updatedWorkData = invoiceHandler.SetDoneWorkDataToInvoiced(workData);

await workDataCommandRepository.SetWorkDataAsync(updatedWorkData);