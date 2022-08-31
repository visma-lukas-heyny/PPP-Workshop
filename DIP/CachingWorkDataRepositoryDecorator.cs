using DIP.Abstractions;

namespace DIP;

public class CachingWorkDataRepositoryDecorator
    : IWorkDataQueryRepository
{
    private readonly IWorkDataQueryRepository _decorated;

    private string[]? _cache = null;

    public CachingWorkDataRepositoryDecorator(IWorkDataQueryRepository decorated)
    {
        _decorated = decorated;
    }

    public async Task<IEnumerable<string>> GetWorkDataAsync()
    {
        _cache ??= (await _decorated.GetWorkDataAsync()).ToArray();  
        return _cache;
    }
}


