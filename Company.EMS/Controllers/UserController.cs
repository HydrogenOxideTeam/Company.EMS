using System.Security.Authentication;
using Company.EMS.CQS.Commands.UserLogin;
using Company.EMS.CQS.Commands.UserRegister;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Company.EMS.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController(IMediator mediator): ControllerBase
{
    private readonly IMediator _mediator = mediator;
    
    [HttpPost]
    [Route("register")]
    public async Task<IActionResult> RegisterAsync(RegisterCommand request)
    {
        try
        {
            var token = await _mediator.Send(request, CancellationToken.None);
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
    public async Task<IActionResult> LoginAsync(LoginCommand request)
    {
        try
        {
            var token = await _mediator.Send(request, CancellationToken.None);
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