using Company.EMS.Models.DTOs;

namespace Company.EMS.Services.Abstractions;

public interface IDeveloperService
{
    Task<List<DeveloperDto>> GetAllAsync();
    Task<DeveloperDto> GetByIdAsync(int id);
    Task<DeveloperDto> AddAsync(DeveloperDto developer);
    Task UpdateAsync(DeveloperDto developer);
    Task DeleteAsync(int id);
}