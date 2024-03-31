using Company.EMS.Models.DTOs;

namespace Company.EMS.Services.Abstractions;

public interface ISalesManagerService
{
    Task<List<SalesManagerDto>> GetAllAsync();
    Task<SalesManagerDto> GetByIdAsync(int id);
    Task<SalesManagerDto> AddAsync(SalesManagerDto salesManager);
    Task UpdateAsync(SalesManagerDto salesManager);
    Task DeleteAsync(int id);
}