namespace ISP.Abstractions;

public interface IUiClient
{
    void Output(string text);
    string? GetInput();
    void Reset();
}