using Gym.Domain.Enums;

namespace Gym.Application.UseCases.Autehntication;

public class LoginResponse
{
    public Guid Id { get; set; }
    public string FullName { get; set; }
    public Role Role { get; set; }
    
}