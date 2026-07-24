using Gym.Application.Interfaces;
using Gym.Application.UseCases.Autehntication;
using Gym.Infrastructure.Persistence;
using Gym.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Controllers and swagger
builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddScoped<LoginUseCase>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddDbContext<GymDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Configure SQLite 
var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider
        .GetRequiredService<GymDbContext>();

    await DatabaseInitializer.InitializeAsync(context);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();