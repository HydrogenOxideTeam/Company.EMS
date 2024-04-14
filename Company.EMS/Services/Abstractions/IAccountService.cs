using Company.EMS.Models.DTOs;

namespace Company.EMS.Services.Abstractions;

public interface IAccountService
{
    Task<IEnumerable<AccountDto>> GetAllAsync();
    Task<AccountDto?> GetByIdAsync(int id);
    Task<AccountDto?> AddAsync(AccountDto? accountDto);
    Task UpdateAsync(int id, AccountDto? accountDto);
    Task DeleteByIdAsync(int id);
}