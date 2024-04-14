using System.Security.Authentication;
using Company.EMS.Models.DTOs;
using Company.EMS.Services.Abstractions;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Company.EMS.Controllers;

/// <summary>
/// 
/// </summary>
/// <param name="userService"></param>
[ApiController]
[Route("[controller]")]
public class UsersController(IUserService userService): ControllerBase
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    /// <exception cref="AuthenticationException"></exception>
    [HttpPost]
    [Route("register")]
    public async Task<IActionResult> RegisterAsync(RegisterDto request)
    {
        try
        {
            var token = await userService.RegisterUserAsync(request);
            
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
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    /// <exception cref="AuthenticationException"></exception>
    [HttpPost]
    [Route("login")]
    public async Task<IActionResult> LoginAsync(LoginDto request)
    {
        try
        {
            var token = await userService.LoginUserAsync(request);
            
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