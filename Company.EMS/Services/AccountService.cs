using System.Text.RegularExpressions;
using AutoMapper;
using Company.EMS.Models.DTOs;
using Company.EMS.Models.Entities;
using Company.EMS.Repositories.Generic;
using Company.EMS.Services.Abstractions;

namespace Company.EMS.Services;

public class AccountService(IMapper mapper, IUnitOfWork unitOfWork): IAccountService
{
    public async Task<IEnumerable<AccountDto>> GetAllAsync()
    {
        var accounts = await unitOfWork.Accounts.GetAllAsync();
        
        return mapper.Map<IEnumerable<AccountDto>>(accounts);
    }

    public async Task<AccountDto?> GetByIdAsync(int id)
    {
        var account = await unitOfWork.Accounts.GetByIdAsync(id);
        
        return mapper.Map<AccountDto>(account);
    }

    public async Task<AccountDto?> AddAsync(AccountDto? accountDto)
    {
        var account = mapper.Map<Account>(accountDto);
        var accountAdded = await unitOfWork.Accounts.AddAsync(account);
        
        await unitOfWork.CompleteAsync();
        
        return mapper.Map<AccountDto>(accountAdded);
    }

    public async Task UpdateAsync(int id, AccountDto? accountDto)
    {
        var account = mapper.Map<Account>(accountDto);
        await unitOfWork.Accounts.UpdateAsync(id, account);
        
        await unitOfWork.CompleteAsync();
    }

    public async Task DeleteByIdAsync(int id)
    {
        await unitOfWork.Accounts.DeleteByIdAsync(id);
        
        await unitOfWork.CompleteAsync();
    }
}