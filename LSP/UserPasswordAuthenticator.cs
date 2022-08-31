using LSP.Abstractions;

namespace LSP;

public class UserPasswordAuthenticator : IAuthenticator
{
    private readonly IUiClient _uiClient;
    private string? _user = null;
    private string? _password = null;

    public UserPasswordAuthenticator(IUiClient uiClient)
    {
        _uiClient = uiClient;
    }

    private void PromptForCredentials()
    {
        const string userPrompt = "User?";
        const string passwordPrompt = "Password?";
    
        _uiClient.Output(userPrompt);
        _user = _uiClient.GetInput();
        _uiClient.Output(passwordPrompt);
        _password = _uiClient.GetInput();
        _uiClient.Reset();
    }

    private bool IsAuthenticated()
    {
        const string allowedUser = "admin";
        const string allowedPassword = "root";

        return _user == allowedUser && _password == allowedPassword;
    }

    public void RequireAuthentication()
    {
        while (!IsAuthenticated())
        {
            PromptForCredentials();
        }
    }
}