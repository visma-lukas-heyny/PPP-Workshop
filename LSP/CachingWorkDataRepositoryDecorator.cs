using LSP.Abstractions;

namespace LSP;

public class CachingWorkDataRepositoryDecorator : IWorkDataRepository
{
    private readonly IWorkDataRepository _decorated;

    private string[]? _cache = null;

    public CachingWorkDataRepositoryDecorator(IWorkDataRepository decorated)
    {
        _decorated = decorated;
    }

    public async Task<IEnumerable<string>> GetWorkData()
    {
        _cache ??= (await _decorated.GetWorkData()).ToArray();  
        return _cache;
    }
}


