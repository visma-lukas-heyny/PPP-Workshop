namespace OCP;

public class ConsoleUiClient //Adapter?
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