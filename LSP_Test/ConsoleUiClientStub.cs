using LSP.Abstractions;

namespace LSP_Tests;

public class ConsoleUiClientStub : IUiClient
{
    private readonly string? _getInputReturnValue;

    public ConsoleUiClientStub(string? getInputReturnValue = null)
    {
        _getInputReturnValue = getInputReturnValue;
    }

    public void Output(string text)
    {
    }

    public string? GetInput()
    {
        return _getInputReturnValue;
    }

    public void Reset()
    {
    }
}