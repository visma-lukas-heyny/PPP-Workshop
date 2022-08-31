namespace DIP.Abstractions;

public interface IUiClient
{
    void Output(string text);
    string? GetInput();
    void Reset();
}