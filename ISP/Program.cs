
using ISP;

// MyPSA

var uiClient = new ConsoleUiClient();
var authenticator = new UserPasswordAuthenticator(uiClient);
var workDataRepository = new CachingWorkDataRepositoryDecorator(new WorkDataFileRepository());

const decimal totalInvoiceAmount = 5000m;
var reporter = new InvoiceAmountAverageReporter(totalInvoiceAmount, uiClient);


authenticator.RequireAuthentication();

var workData = await workDataRepository.GetWorkData();

reporter.PrintReport(reporter.CreateReport(workData)); 
