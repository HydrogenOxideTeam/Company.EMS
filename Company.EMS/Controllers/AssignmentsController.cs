using Company.EMS.Models.DTOs;
using Company.EMS.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Company.EMS.Controllers;

/// <summary>
/// 
/// </summary>
/// <param name="assignmentService"></param>
[ApiController]
[Route("api/[controller]")]
public class AssignmentsController(IAssignmentService assignmentService): ControllerBase
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<IActionResult> GetAllAssignments()
    {
        try
        {
            var assignments = await assignmentService.GetAllAsync();
            
            return Ok(assignments);
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
    public async Task<IActionResult> GetAssignmentById(int id)
    {
        try
        {
            var assignment = await assignmentService.GetByIdAsync(id);
            
            if (assignment == null) return NotFound();
            
            return Ok(assignment);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Internal server error: " + ex.Message);
        }
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="assignment"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> AddAssignment([FromBody] AssignmentDto assignment)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        try
        {
            var assignmentAdded = await assignmentService.AddAsync(assignment);
            
            return CreatedAtAction(nameof(GetAssignmentById), new { id = assignmentAdded?.Id }, assignmentAdded);
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
    /// <param name="assignment"></param>
    /// <returns></returns>
    [HttpPut]
    [Route("{id}")]
    public async Task<IActionResult> UpdateAssignment(int id, [FromBody] AssignmentDto assignment)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);
        try
        {
            await assignmentService.UpdateAsync(id, assignment);
            
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
    public async Task<IActionResult> DeleteAssignment(int id)
    {
        try
        {
            await assignmentService.DeleteByIdAsync(id);
            
            return NoContent();
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Internal server error: " + ex.Message);
        }
    }
}
