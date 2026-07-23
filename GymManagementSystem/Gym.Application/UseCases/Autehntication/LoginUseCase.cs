namespace Gym.Application.UseCases.Autehntication;

public class LoginUseCase
{
    public LoginResponse Execute(LoginRequest request)
    {
        if (request.email == "admin@gym.com" && request.password == "123456789")
        {
            return new LoginResponse
            {
                Id = Guid.NewGuid(),
                FullName = "Admin",
                Role = Domain.Enums.Role.Admin
            };
        }
        else
        {
            throw new UnauthorizedAccessException("Invalid credentials");
        }
    }
}