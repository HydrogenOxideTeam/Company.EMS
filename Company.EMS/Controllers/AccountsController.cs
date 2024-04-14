using Company.EMS.Models.DTOs;
using Company.EMS.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Company.EMS.Controllers;

/// <summary>
/// 
/// </summary>
/// <param name="accountService"></param>
[ApiController]
[Route("api/[controller]")]
public class AccountsController(IAccountService accountService): ControllerBase
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<IActionResult> GetAllAccounts()
    {
        try
        {
            var accounts = await accountService.GetAllAsync();
            
            return Ok(accounts);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Internal server error: " + ex.Message);
        }
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> GetAccountById(int id)
    {
        try
        {
            var account = await accountService.GetByIdAsync(id);
            
            if (account == null) return NotFound();
            
            return Ok(account);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Internal server error: " + ex.Message);
        }
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="account"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> AddAccount([FromBody] AccountDto account)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        try
        {
            var accountAdded = await accountService.AddAsync(account);
            
            return CreatedAtAction(nameof(GetAccountById), new { id = accountAdded?.Id }, accountAdded);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Internal server error: " + ex.Message);
        }
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <param name="account"></param>
    /// <returns></returns>
    [HttpPut]
    [Route("{id}")]
    public async Task<IActionResult> UpdateAccount(int id, [FromBody] AccountDto account)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        try
        {
            await accountService.UpdateAsync(id, account);
            
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Internal server error: " + ex.Message);
        }
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpDelete]
    [Route("{id}")]
    public async Task<IActionResult> DeleteAccount(int id)
    {
        try
        {
            await accountService.DeleteByIdAsync(id);
            
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Internal server error: " + ex.Message);
        }
    }
}