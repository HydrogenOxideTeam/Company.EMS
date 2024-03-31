using Company.EMS.Models.DTOs;
using Company.EMS.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Company.EMS.Controllers;

[ApiController]
[Route("[controller]")]
public class AssignmentsController(IAssignmentService assignmentService): ControllerBase
{
    private readonly IAssignmentService _assignmentService = assignmentService;
    
    [HttpGet]
    public async Task<IActionResult> GetAllAssignments()
    {
        try
        {
            var assignments = await _assignmentService.GetAllAsync();
            return Ok(assignments);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> GetAssignmentById(int id)
    {
        try
        {
            var assignment = await _assignmentService.GetByIdAsync(id);
            return Ok(assignment);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpPost]
    public async Task<IActionResult> AddAssignment([FromBody] AssignmentDto assignment)
    {
        try
        {
            var assignmentAdded = await _assignmentService.AddAsync(assignment);
            return Ok(assignmentAdded);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpPut]
    [Route("{id}")]
    public async Task<IActionResult> UpdateAssignment(int id, [FromBody] AssignmentDto assignment)
    {
        try
        {
            await _assignmentService.UpdateAsync(id, assignment);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpDelete]
    [Route("{id}")]
    public async Task<IActionResult> DeleteAssignment(int id)
    {
        try
        {
            await _assignmentService.DeleteAsync(id);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}