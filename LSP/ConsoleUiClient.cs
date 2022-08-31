using LSP.Abstractions;

namespace LSP;

public class ConsoleUiClient : IUiClient
{
    public void Output(string text)
    {
        Console.WriteLine(text);
    }

    public string? GetInput()
    {
        return  Console.ReadLine();
    }

    public void Reset()
    {
       Console.Clear();
    }
}