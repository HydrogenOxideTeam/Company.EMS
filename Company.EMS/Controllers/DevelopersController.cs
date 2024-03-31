using Company.EMS.Models.DTOs;
using Company.EMS.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Company.EMS.Controllers;

[ApiController]
[Route("[controller]")]
public class DevelopersController(IDeveloperService developerService): ControllerBase
{
    private readonly IDeveloperService _developerService = developerService;
    
    [HttpGet]
    public async Task<IActionResult> GetAllDevelopers()
    {
        try
        {
            var developers = await _developerService.GetAllAsync();
            return Ok(developers);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> GetDeveloperById(int id)
    {
        try
        {
            var developer = await _developerService.GetByIdAsync(id);
            return Ok(developer);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpPost]
    public async Task<IActionResult> AddDeveloper([FromBody] DeveloperDto developer)
    {
        try
        {
            var developerAdded = await _developerService.AddAsync(developer);
            return Ok(developerAdded);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpPut]
    [Route("{id}")]
    public async Task<IActionResult> UpdateDeveloper(int id, [FromBody] DeveloperDto developer)
    {
        try
        {
            await _developerService.UpdateAsync(id, developer);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpDelete]
    [Route("{id}")]
    public async Task<IActionResult> DeleteDeveloper(int id)
    {
        try
        {
            await _developerService.DeleteAsync(id);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}