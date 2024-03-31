using Company.EMS.Models.DTOs;
using Company.EMS.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Company.EMS.Controllers;

[ApiController]
[Route("[controller]")]
public class EngagementsController(IEngagementService engagementService): ControllerBase
{
    private readonly IEngagementService _engagementService = engagementService;
    
    [HttpGet]
    public async Task<IActionResult> GetAllEngagements()
    {
        try
        {
            var engagements = await _engagementService.GetAllAsync();
            return Ok(engagements);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> GetEngagementById(int id)
    {
        try
        {
            var engagement = await _engagementService.GetByIdAsync(id);
            return Ok(engagement);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpPost]
    public async Task<IActionResult> AddEngagement([FromBody] EngagementDto engagement)
    {
        try
        {
            var engagementAdded = await _engagementService.AddAsync(engagement);
            return Ok(engagementAdded);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpPut]
    [Route("{id}")]
    public async Task<IActionResult> UpdateEngagement(int id, [FromBody] EngagementDto engagement)
    {
        try
        {
            await _engagementService.UpdateAsync(id, engagement);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpDelete]
    [Route("{id}")]
    public async Task<IActionResult> DeleteEngagement(int id)
    {
        try
        {
            await _engagementService.DeleteAsync(id);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}