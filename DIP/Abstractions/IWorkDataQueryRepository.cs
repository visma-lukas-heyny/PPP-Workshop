namespace DIP.Abstractions;

public interface IWorkDataQueryRepository
{
    Task<IEnumerable<string>> GetWorkDataAsync();
}