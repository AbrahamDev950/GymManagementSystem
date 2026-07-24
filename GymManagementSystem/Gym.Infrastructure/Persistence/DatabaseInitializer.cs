using Gym.Domain.Entities;
using Gym.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Gym.Infrastructure.Persistence;

public static class DatabaseInitializer
{
    public static async Task InitializeAsync(GymDbContext context)
    {
        await context.Database.MigrateAsync();

        if (await context.Users.AnyAsync())
        {
            return;
        }

        var administrator = new User(
            "Admin",
            "Principal",
            "admin@gym.com",
            "0000000000",
            Role.Admin,
            "123456789"
        );
        
        administrator.SwitchStatus();

        await context.Users.AddAsync(administrator);

        await context.SaveChangesAsync();
    }
}