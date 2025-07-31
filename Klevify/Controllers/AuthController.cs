using Klevify.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using KlevifyServer.Models;
using Klevify.Core.Common;

namespace KlevifyServer.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly IUserService _userService;

    public AuthController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterRequest request)
    {
        try
        {
            var result = await _userService.RegisterAsync(request.Email, request.Password);

            if (result.Success)
                return Ok("Registration successful");

            return BadRequest(result.ErrorMessage);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}
