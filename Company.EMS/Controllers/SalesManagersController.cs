using Company.EMS.Models.DTOs;
using Company.EMS.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Company.EMS.Controllers;

[ApiController]
[Route("[controller]")]
public class SalesManagersController(ISalesManagerService salesManagerService): ControllerBase
{
    private readonly ISalesManagerService _salesManagerService = salesManagerService;
    
    [HttpGet]
    public async Task<IActionResult> GetAllSalesManagers()
    {
        try
        {
            var salesManagers = await _salesManagerService.GetAllAsync();
            return Ok(salesManagers);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> GetSalesManagerById(int id)
    {
        try
        {
            var salesManager = await _salesManagerService.GetByIdAsync(id);
            return Ok(salesManager);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpPost]
    public async Task<IActionResult> AddSalesManager([FromBody] SalesManagerDto salesManager)
    {
        try
        {
            var salesManagerAdded = await _salesManagerService.AddAsync(salesManager);
            return Ok(salesManagerAdded);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpPut]
    [Route("{id}")]
    public async Task<IActionResult> UpdateSalesManager(int id, [FromBody] SalesManagerDto salesManager)
    {
        try
        {
            await _salesManagerService.UpdateAsync(id, salesManager);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpDelete]
    [Route("{id}")]
    public async Task<IActionResult> DeleteSalesManager(int id)
    {
        try
        {
            await _salesManagerService.DeleteAsync(id);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}