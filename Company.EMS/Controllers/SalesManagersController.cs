using Company.EMS.Models.DTOs;
using Company.EMS.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Company.EMS.Controllers;

/// <summary>
/// 
/// </summary>
/// <param name="salesManagerService"></param>
[ApiController]
[Route("api/[controller]")]
public class SalesManagersController(ISalesManagerService salesManagerService) : ControllerBase
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<IActionResult> GetAllSalesManagers()
    {
        try
        {
            var salesManagers = await salesManagerService.GetAllAsync();
            
            return Ok(salesManagers);
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
    public async Task<IActionResult> GetSalesManagerById(int id)
    {
        try
        {
            var salesManager = await salesManagerService.GetByIdAsync(id);
            
            if (salesManager == null) return NotFound();
            
            return Ok(salesManager);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Internal server error: " + ex.Message);
        }
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="salesManager"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> AddSalesManager([FromBody] SalesManagerDto salesManager)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        try
        {
            var salesManagerAdded = await salesManagerService.AddAsync(salesManager);
            
            return CreatedAtAction(nameof(GetSalesManagerById), 
                new { id = salesManagerAdded?.Id }, salesManagerAdded);
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
    /// <param name="salesManager"></param>
    /// <returns></returns>
    [HttpPut]
    [Route("{id}")]
    public async Task<IActionResult> UpdateSalesManager(int id, [FromBody] SalesManagerDto salesManager)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        try
        {
            await salesManagerService.UpdateAsync(id, salesManager);
            
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
    public async Task<IActionResult> DeleteSalesManager(int id)
    {
        try
        {
            await salesManagerService.DeleteByIdAsync(id);
            
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Internal server error: " + ex.Message);
        }
    }
}
