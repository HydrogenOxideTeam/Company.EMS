using Company.EMS.Models.DTOs;
using Company.EMS.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Company.EMS.Controllers;

/// <summary>
/// 
/// </summary>
/// <param name="engagementService"></param>
[ApiController]
[Route("api/[controller]")]
public class EngagementsController(IEngagementService engagementService) : ControllerBase
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<IActionResult> GetAllEngagements()
    {
        try
        {
            var engagements = await engagementService.GetAllAsync();
            return Ok(engagements);
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
    public async Task<IActionResult> GetEngagementById(int id)
    {
        try
        {
            var engagement = await engagementService.GetByIdAsync(id);
            if (engagement == null) return NotFound();
            return Ok(engagement);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Internal server error: " + ex.Message);
        }
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="engagement"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> AddEngagement([FromBody] EngagementDto engagement)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        try
        {
            var engagementAdded = await engagementService.AddAsync(engagement);
            
            return CreatedAtAction(nameof(GetEngagementById), 
                new { id = engagementAdded?.Id }, engagementAdded);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Internal server error: " + ex.Message);
        }
    }
    
    [HttpPut]
    [Route("{id}")]
    public async Task<IActionResult> UpdateEngagement(int id, [FromBody] EngagementDto engagement)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        try
        {
            await engagementService.UpdateAsync(id, engagement);
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
    public async Task<IActionResult> DeleteEngagement(int id)
    {
        try
        {
            await engagementService.DeleteByIdAsync(id);
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Internal server error: " + ex.Message);
        }
    }
}
