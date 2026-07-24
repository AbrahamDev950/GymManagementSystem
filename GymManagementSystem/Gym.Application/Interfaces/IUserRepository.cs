using Gym.Domain.Entities;

namespace Gym.Application.Interfaces;

public interface IUserRepository
{
    Task<User?> GetUserByEmailAsync(string email);
}