using DIP.Abstractions;

namespace DIP;

public class WorkDataFileRepository  
    : IWorkDataQueryRepository, IWorkDataCommandRepository
{
    private const string DataFile = "data.txt";

    public async Task<IEnumerable<string>> GetWorkDataAsync()
    {
        return await File.ReadAllLinesAsync(DataFile);
    }

    public async Task SetWorkDataAsync(IEnumerable<string> workData)
    {
        await File.WriteAllLinesAsync(DataFile, workData);
    }
}