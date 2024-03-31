using AutoMapper;
using Company.EMS.Models.DTOs;
using Company.EMS.Models.Entities;
using Company.EMS.Repositories.Abstractions;
using Company.EMS.Services.Abstractions;

namespace Company.EMS.Services;

public class AccountService(IMapper mapper, IAccountRepository accountRepository): IAccountService
{
    private readonly IMapper _mapper = mapper;
    private readonly IAccountRepository _accountRepository = accountRepository;
    
    public async Task<List<AccountDto>> GetAllAsync()
    {
        return _mapper.Map<List<AccountDto>>((await _accountRepository.GetAllAsync())?.ToList());
    }

    public async Task<AccountDto> GetByIdAsync(int id)
    {
        return _mapper.Map<AccountDto>(await _accountRepository.GetByIdAsync(id));
    }

    public async Task<AccountDto> AddAsync(AccountDto account)
    {
        return _mapper.Map<AccountDto>(await _accountRepository.AddAsync(_mapper.Map<Account>(account)));
    }

    public async Task UpdateAsync(AccountDto account)
    {
        await _accountRepository.UpdateAsync(_mapper.Map<Account>(account));
    }

    public async Task DeleteAsync(int id)
    {
        await _accountRepository.DeleteAsync(id);
    }
}