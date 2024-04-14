using Company.EMS.Models.DTOs;
using Company.EMS.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Company.EMS.Controllers;

/// <summary>
/// 
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class ProjectManagersController(IProjectManagerService projectManagerService): ControllerBase
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<IActionResult> GetAllProjectManagers()
    {
        try
        {
            var projectManagers = await projectManagerService.GetAllAsync();
            
            return Ok(projectManagers);
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
    public async Task<IActionResult> GetProjectManagerById(int id)
    {
        try
        {
            var projectManager = await projectManagerService.GetByIdAsync(id);
            
            if (projectManager == null) return NotFound();
            
            return Ok(projectManager);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Internal server error: " + ex.Message);
        }
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="projectManager"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> AddProjectManager([FromBody] ProjectManagerDto projectManager)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        try
        {
            var projectManagerAdded = await projectManagerService.AddAsync(projectManager);
            
            return CreatedAtAction(nameof(GetProjectManagerById), new { id = projectManagerAdded?.Id }, projectManagerAdded);
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
    /// <param name="projectManager"></param>
    /// <returns></returns>
    [HttpPut]
    [Route("{id}")]
    public async Task<IActionResult> UpdateProjectManager(int id, [FromBody] ProjectManagerDto projectManager)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        try
        {
            await projectManagerService.UpdateAsync(id, projectManager);
            
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
    public async Task<IActionResult> DeleteProjectManager(int id)
    {
        try
        {
            await projectManagerService.DeleteByIdAsync(id);
            
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Internal server error: " + ex.Message);
        }
    }
}