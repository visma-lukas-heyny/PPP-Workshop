
using OCP;

// MyPSA

var uiClient = new ConsoleUiClient();
var authenticator = new UserPasswordAuthenticator(uiClient);
var reporter = new InvoiceReporter(uiClient);
var workDataRepository = new WorkDataFileRepository();

authenticator.RequireAuthentication();

var workData = await workDataRepository.GetWorkData();

reporter.PrintReport(reporter.CreateReport(workData)); 

