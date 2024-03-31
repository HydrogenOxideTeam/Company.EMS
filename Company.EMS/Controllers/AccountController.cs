using System.ComponentModel;
using Company.EMS.Models.DTOs;
using Company.EMS.Services.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Company.EMS.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountController(IAccountService accountService): ControllerBase
{
    private readonly IAccountService _accountService = accountService;

    [HttpGet]
    [Route("accounts")]
    public async Task<IActionResult> GetAllAccounts()
    {
        try
        {
            var accounts = await _accountService.GetAllAsync();
            return Ok(accounts);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpPost]
    [Route("accounts")]
    public async Task<IActionResult> AddAcount([FromBody] AccountDto account)
    {
        try
        {
            var accountAdded = await _accountService.AddAsync(account);
            return Ok(accountAdded);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [Authorize(AuthenticationSchemes = "Bearer")]
    [HttpGet]
    [Route("api/Tokens")]
    public IActionResult TestAuthorization()
    {
        return Ok("You're Authorized");
    }
}