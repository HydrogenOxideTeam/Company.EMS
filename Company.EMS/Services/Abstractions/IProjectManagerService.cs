using Company.EMS.Models.DTOs;

namespace Company.EMS.Services.Abstractions;

public interface IProjectManagerService
{
    Task<IEnumerable<ProjectManagerDto>> GetAllAsync();
    Task<ProjectManagerDto?> GetByIdAsync(int id);
    Task<ProjectManagerDto?> AddAsync(ProjectManagerDto? projectManagerDto);
    Task UpdateAsync(int id, ProjectManagerDto? projectManagerDto);
    Task DeleteByIdAsync(int id);
}