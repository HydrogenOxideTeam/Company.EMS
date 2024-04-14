using Company.EMS.Models.DTOs;

namespace Company.EMS.Services.Abstractions;

public interface ISalesManagerService
{
    Task<IEnumerable<SalesManagerDto>> GetAllAsync();
    Task<SalesManagerDto?> GetByIdAsync(int id);
    Task<SalesManagerDto?> AddAsync(SalesManagerDto? salesManagerDto);
    Task UpdateAsync(int id, SalesManagerDto? salesManagerDto);
    Task DeleteByIdAsync(int id);
}