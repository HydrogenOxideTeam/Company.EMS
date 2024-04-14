using Company.EMS.Models.DTOs;

namespace Company.EMS.Services.Abstractions;

public interface IAssignmentService
{
    Task<IEnumerable<AssignmentDto>> GetAllAsync();
    Task<AssignmentDto?> GetByIdAsync(int id);
    Task<AssignmentDto?> AddAsync(AssignmentDto? assignmentDto);
    Task UpdateAsync(int id, AssignmentDto? assignmentDto);
    Task DeleteByIdAsync(int id);
}