namespace ISP.Abstractions;

public interface IWorkDataRepository
{
    Task<IEnumerable<string>> GetWorkData();
}