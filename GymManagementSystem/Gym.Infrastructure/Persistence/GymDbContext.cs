using Gym.Domain.Entities;
using Gym.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Gym.Infrastructure.Persistence;

public class GymDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public GymDbContext(DbContextOptions<GymDbContext> options) : base(options)
    {
        
    }
}