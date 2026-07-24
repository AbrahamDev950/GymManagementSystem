using Gym.Application.Interfaces;
using Gym.Domain.Entities;
using Gym.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Gym.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly GymDbContext _context;

    public UserRepository(GymDbContext context)
    {
        _context = context;
    }

    public Task<User?> GetUserByEmailAsync(string email)
    {
        return _context.Users.FirstOrDefaultAsync(x => x.Email == email);
    }
}