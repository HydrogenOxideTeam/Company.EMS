using Company.EMS.Models.DTOs;

namespace Company.EMS.Services.Abstractions;

public interface IProjectManagerService
{
    Task<List<ProjectManagerDto>> GetAllAsync();
    Task<ProjectManagerDto> GetByIdAsync(int id);
    Task<ProjectManagerDto> AddAsync(ProjectManagerDto projectManager);
    Task UpdateAsync(int id, ProjectManagerDto projectManager);
    Task DeleteAsync(int id);
}