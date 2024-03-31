using System.ComponentModel;
using Company.EMS.Models.DTOs;
using Company.EMS.Services.Abstractions;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Company.EMS.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountsController(IAccountService accountService): ControllerBase
{
    private readonly IAccountService _accountService = accountService;

    [HttpGet]
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
    
    [HttpGet]
    [Route("{id:int}")]
    public async Task<IActionResult> GetAccountById([FromQuery] int id)
    {
        try
        {
            var account = await _accountService.GetByIdAsync(id);
            return Ok(account);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpPost]
    public async Task<IActionResult> AddAccount([FromBody] AccountDto account)
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
    
    [HttpPut]
    [Route("{id:int}")]
    public async Task<IActionResult> UpdateAccount([FromQuery] int id)
    {
        try
        {
            var account = await _accountService.GetByIdAsync(id);
            return Ok(account);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
//     [Authorize(AuthenticationSchemes = "Bearer")]
//     [HttpGet]
//     [Route("api/Tokens")]
//     public IActionResult TestAuthorization()
//     {
//         return Ok("You're Authorized");
//     }
}