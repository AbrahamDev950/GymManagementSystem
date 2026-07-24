using Gym.Application.Interfaces;

namespace Gym.Application.UseCases.Autehntication;

public class LoginUseCase
{
    private readonly IUserRepository _userRepository;

    public LoginUseCase(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<LoginResponse> ExecuteAsync(LoginRequest request)
    {
        var user = await _userRepository.GetUserByEmailAsync(request.email);

        if (user is null)
        {
            throw new UnauthorizedAccessException("Invalid credentials.");
        }

        if (user.PasswordHash != request.password)
        {
            throw new UnauthorizedAccessException("Invalid credentials.");
        }

        return new LoginResponse
        {
            Id = user.Id,
            FullName = $"{user.FirstName} {user.LastName}",
            Role = user.Role
        };
    }
}