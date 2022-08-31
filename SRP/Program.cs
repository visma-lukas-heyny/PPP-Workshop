

string? user = null;
string? password = null;


while (!IsAuthenticated())
{
    RequestAuthentication();
}

bool IsAuthenticated()
{
    const string allowedUser = "admin";
    const string allowedPassword = "root";

    return user == allowedUser && password == allowedPassword;
}

void RequestAuthentication()
{
    const string userPrompt = "User?";
    const string passwordPrompt = "Password?";
    
    Console.WriteLine(userPrompt);
    user = Console.ReadLine();
    Console.WriteLine(passwordPrompt);
    password = Console.ReadLine();
    Console.Clear();
}

var workData = await GetWorkData();

async Task<string[]> GetWorkData()
{
    const string dataFile = "data.txt";
    
    return await File.ReadAllLinesAsync(dataFile);
}

PrintReport(CreateInvoiceReport(workData));

void PrintReport(IEnumerable<string> reportData){
    const string invoiceReportHeader = "Send invoice for:";
    
    Console.WriteLine(invoiceReportHeader);
    reportData.ToList().ForEach(Console.WriteLine);
}

IEnumerable<string> CreateInvoiceReport(IEnumerable<string> workData)
{
    const string billableState = "done";
    
    return workData.Where(line => line.EndsWith(billableState));
}



