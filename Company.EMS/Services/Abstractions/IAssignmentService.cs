using Company.EMS.Models.DTOs;

namespace Company.EMS.Services.Abstractions;

public interface IAssignmentService
{
    Task<List<AssignmentDto>> GetAllAsync();
    Task<AssignmentDto> GetByIdAsync(int id);
    Task<AssignmentDto> AddAsync(AssignmentDto assignment);
    Task UpdateAsync(AssignmentDto assignment);
    Task DeleteAsync(int id);
}