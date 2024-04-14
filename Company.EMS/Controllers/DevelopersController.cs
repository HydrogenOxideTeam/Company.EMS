using Company.EMS.Models.DTOs;
using Company.EMS.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Company.EMS.Controllers;

/// <summary>
/// 
/// </summary>
/// <param name="developerService"></param>
[ApiController]
[Route("api/[controller]")]
public class DevelopersController(IDeveloperService developerService): ControllerBase
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<IActionResult> GetAllDevelopers()
    {
        try
        {
            var developers = await developerService.GetAllAsync();
            
            return Ok(developers);
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
    public async Task<IActionResult> GetDeveloperById(int id)
    {
        try
        {
            var developer = await developerService.GetByIdAsync(id);
            
            if (developer == null) return NotFound();
            
            return Ok(developer);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Internal server error: " + ex.Message);
        }
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="developer"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> AddDeveloper([FromBody] DeveloperDto developer)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        try
        {
            var developerAdded = await developerService.AddAsync(developer);
            
            return CreatedAtAction(nameof(GetDeveloperById), new { id = developerAdded?.Id }, developerAdded);
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
    /// <param name="developer"></param>
    /// <returns></returns>
    [HttpPut]
    [Route("{id}")]
    public async Task<IActionResult> UpdateDeveloper(int id, [FromBody] DeveloperDto developer)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        try
        {
            await developerService.UpdateAsync(id, developer);
            
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
    public async Task<IActionResult> DeleteDeveloper(int id)
    {
        try
        {
            await developerService.DeleteByIdAsync(id);
            
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Internal server error: " + ex.Message);
        }
    }
}
