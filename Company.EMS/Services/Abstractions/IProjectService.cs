using Company.EMS.Models.DTOs;

namespace Company.EMS.Services.Abstractions;

public interface IProjectService
{
    Task<IEnumerable<ProjectDto>> GetAllAsync();
    Task<ProjectDto?> GetByIdAsync(int id);
    Task<ProjectDto?> AddAsync(ProjectDto? projectDto);
    Task UpdateAsync(int id, ProjectDto? projectDto);
    Task DeleteByIdAsync(int id);
}