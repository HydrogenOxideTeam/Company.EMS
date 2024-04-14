using Company.EMS.Models.DTOs;

namespace Company.EMS.Services.Abstractions;

public interface IEngagementService
{
    Task<IEnumerable<EngagementDto>> GetAllAsync();
    Task<EngagementDto?> GetByIdAsync(int id);
    Task<EngagementDto?> AddAsync(EngagementDto? engagementDto);
    Task UpdateAsync(int id, EngagementDto? engagementDto);
    Task DeleteByIdAsync(int id);
}