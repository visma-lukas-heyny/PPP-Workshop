using LSP.Abstractions;

namespace LSP;

public class WorkDataFileRepository : IWorkDataRepository
{
    public async Task<IEnumerable<string>> GetWorkData()
    {
        const string dataFile = "data.txt";
    
        return await File.ReadAllLinesAsync(dataFile);
    }
}