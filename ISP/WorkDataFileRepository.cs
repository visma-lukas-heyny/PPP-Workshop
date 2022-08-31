using ISP.Abstractions;

namespace ISP;

public class WorkDataFileRepository : IWorkDataRepository
{
    public async Task<IEnumerable<string>> GetWorkData()
    {
        const string dataFile = "data.txt";
    
        return await File.ReadAllLinesAsync(dataFile);
    }
}