namespace Gym.Application.UseCases.Autehntication;

public class LoginRequest
{
    public string email { get; set; }
    public string password { get; set; }

    public LoginRequest()
    {
        this.email = string.Empty;
        this.password = string.Empty;
    }
}