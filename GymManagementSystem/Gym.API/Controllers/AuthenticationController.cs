using Gym.Application.UseCases.Autehntication;
using Microsoft.AspNetCore.Mvc;

namespace Gym.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthenticationController :  ControllerBase
{
    private readonly LoginUseCase _loginUseCase;

    public AuthenticationController(LoginUseCase loginUseCase)
    {
        _loginUseCase =  loginUseCase;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        try
        {
            var response = await _loginUseCase.ExecuteAsync(request);
            return Ok(response);
        }
        catch (UnauthorizedAccessException ex)
        {
            return Unauthorized(new { message = ex.Message });
        }
    }
}