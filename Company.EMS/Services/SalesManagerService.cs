using AutoMapper;
using Company.EMS.Models.DTOs;
using Company.EMS.Models.Entities;
using Company.EMS.Repositories.Abstractions;
using Company.EMS.Services.Abstractions;

namespace Company.EMS.Services;

public class SalesManagerService(IMapper mapper, ISalesManagerRepository salesManagerRepository): ISalesManagerService
{
    private readonly IMapper _mapper = mapper;
    private readonly ISalesManagerRepository _salesManagerRepository = salesManagerRepository;
    
    public async Task<List<SalesManagerDto>> GetAllAsync()
    {
        return _mapper.Map<List<SalesManagerDto>>((await _salesManagerRepository.GetAllAsync())?.ToList());
    }

    public async Task<SalesManagerDto> GetByIdAsync(int id)
    {
        return _mapper.Map<SalesManagerDto>(await _salesManagerRepository.GetByIdAsync(id));
    }

    public async Task<SalesManagerDto> AddAsync(SalesManagerDto salesManager)
    {
        return _mapper.Map<SalesManagerDto>(await _salesManagerRepository.AddAsync(_mapper.Map<SalesManager>(salesManager)));
    }

    public async Task UpdateAsync(int id, SalesManagerDto salesManager)
    {
        await _salesManagerRepository.UpdateAsync(id,_mapper.Map<SalesManager>(salesManager));
    }

    public async Task DeleteAsync(int id)
    {
        await _salesManagerRepository.DeleteAsync(id);
    }
}