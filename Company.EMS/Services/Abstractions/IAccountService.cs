using Company.EMS.Models.DTOs;
using Company.EMS.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Company.EMS.Services.Abstractions;

public interface IAccountService
{
    Task<List<AccountDto>> GetAllAsync();
    Task<AccountDto> GetByIdAsync(int id);
    Task<AccountDto> AddAsync(AccountDto account);
    Task UpdateAsync(int id, AccountDto account);
    Task DeleteAsync(int id);
}