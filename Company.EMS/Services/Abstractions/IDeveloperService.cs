using Company.EMS.Models.DTOs;

namespace Company.EMS.Services.Abstractions;

public interface IDeveloperService
{
    Task<IEnumerable<DeveloperDto>> GetAllAsync();
    Task<DeveloperDto?> GetByIdAsync(int id);
    Task<DeveloperDto?> AddAsync(DeveloperDto? developerDto);
    Task UpdateAsync(int id, DeveloperDto? developerDto);
    Task DeleteByIdAsync(int id);
}