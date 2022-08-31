namespace LSP.Abstractions;

public interface IWorkDataRepository
{
    Task<IEnumerable<string>> GetWorkData();
}