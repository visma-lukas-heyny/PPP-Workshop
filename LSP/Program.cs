
using LSP;

// MyPSA

var uiClient = new ConsoleUiClient();
var authenticator = new UserPasswordAuthenticator(uiClient);
var reporter = new BaseInvoiceReporter(uiClient);
var workDataRepository = new CachingWorkDataRepositoryDecorator(new WorkDataFileRepository());

authenticator.RequireAuthentication();

var workData = await workDataRepository.GetWorkData();

reporter.PrintReport(reporter.CreateReport(workData)); 
