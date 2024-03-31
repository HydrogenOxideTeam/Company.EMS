using Company.EMS.Models.DTOs;

namespace Company.EMS.Services.Abstractions;

public interface IEngagementService
{
    Task<List<EngagementDto>> GetAllAsync();
    Task<EngagementDto> GetByIdAsync(int id);
    Task<EngagementDto> AddAsync(EngagementDto engagement);
    Task UpdateAsync(EngagementDto engagement);
    Task DeleteAsync(int id);
}