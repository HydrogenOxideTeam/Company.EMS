using System.Security.Authentication;
using Company.EMS.Models.DTOs;
using Company.EMS.Services.Abstractions;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Company.EMS.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController(IUserService userService): ControllerBase
{
    private readonly IUserService _userService = userService;
    
    [HttpPost]
    [Route("register")]
    public async Task<IActionResult> RegisterAsync(RegisterDto request)
    {
        try
        {
            var token = await _userService.RegisterUserAsync(request);
            if (!string.IsNullOrEmpty(token))
            {
                return Ok(token);
            }

            throw new AuthenticationException("User was not registered");
        }
        catch (AuthenticationException ex)
        {
            return Unauthorized(ex.Message);
        }
        catch (ValidationException ex)
        {
            return ValidationProblem(ex.Message);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Data);
        }
    }
    
    [HttpPost]
    [Route("login")]
    public async Task<IActionResult> LoginAsync(LoginDto request)
    {
        try
        {
            var token = await _userService.LoginUserAsync(request);
            if (!string.IsNullOrEmpty(token))
            {
                return Ok(token);
            }

            throw new AuthenticationException("User was not logged in");
        }
        catch (InvalidDataException ex)
        {
            return Unauthorized(ex.Message);
        }
        catch (AuthenticationException ex)
        {
            return Unauthorized(ex.Message);
        }
        
        catch (ValidationException ex)
        {
            return ValidationProblem(ex.Message);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Data);
        }
    }
}