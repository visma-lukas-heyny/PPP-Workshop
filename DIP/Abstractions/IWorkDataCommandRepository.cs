namespace DIP.Abstractions;

public interface IWorkDataCommandRepository
{
    Task SetWorkDataAsync(IEnumerable<string> workData);
}