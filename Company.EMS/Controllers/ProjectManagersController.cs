using Company.EMS.Models.DTOs;
using Company.EMS.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Company.EMS.Controllers;

[ApiController]
[Route("[controller]")]
public class ProjectManagersController(IProjectManagerService projectManagerService): ControllerBase
{
    private readonly IProjectManagerService _projectManagerService = projectManagerService;
    
    [HttpGet]
    public async Task<IActionResult> GetAllProjectManagers()
    {
        try
        {
            var projectManagers = await _projectManagerService.GetAllAsync();
            return Ok(projectManagers);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> GetProjectManagerById(int id)
    {
        try
        {
            var projectManager = await _projectManagerService.GetByIdAsync(id);
            return Ok(projectManager);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpPost]
    public async Task<IActionResult> AddProjectManager([FromBody] ProjectManagerDto projectManager)
    {
        try
        {
            var projectManagerAdded = await _projectManagerService.AddAsync(projectManager);
            return Ok(projectManagerAdded);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpPut]
    [Route("{id}")]
    public async Task<IActionResult> UpdateProjectManager(int id, [FromBody] ProjectManagerDto projectManager)
    {
        try
        {
            await _projectManagerService.UpdateAsync(id, projectManager);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpDelete]
    [Route("{id}")]
    public async Task<IActionResult> DeleteProjectManager(int id)
    {
        try
        {
            await _projectManagerService.DeleteAsync(id);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}