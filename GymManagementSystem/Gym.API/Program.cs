using Gym.Application.UseCases.Autehntication;

var builder = WebApplication.CreateBuilder(args);

// Controllers and swagger
builder.Services.AddControllers();
builder.Services.AddOpenApi();
builder.Services.AddScoped<LoginUseCase>();

// Configure SQLite 
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();