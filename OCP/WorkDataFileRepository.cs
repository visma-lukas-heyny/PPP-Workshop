namespace OCP;

public class WorkDataFileRepository 
{
    public async Task<IEnumerable<string>> GetWorkData()  //Entities?
    {
        const string dataFile = "data.txt";
    
        return await File.ReadAllLinesAsync(dataFile);
    }
}