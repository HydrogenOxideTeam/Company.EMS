using AutoMapper;
using Company.EMS.Models.DTOs;
using Company.EMS.Models.Entities;
using Company.EMS.Repositories.Abstractions;
using Company.EMS.Services.Abstractions;

namespace Company.EMS.Services;

public class EngagementService(IMapper mapper, IEngagementRepository engagementRepository): IEngagementService
{
    private readonly IMapper _mapper = mapper;
    private readonly IEngagementRepository _engagementRepository = engagementRepository;
    
    public async Task<List<EngagementDto>> GetAllAsync()
    {
        return _mapper.Map<List<EngagementDto>>((await _engagementRepository.GetAllAsync())?.ToList());
    }

    public async Task<EngagementDto> GetByIdAsync(int id)
    {
        return _mapper.Map<EngagementDto>(await _engagementRepository.GetByIdAsync(id));
    }

    public async Task<EngagementDto> AddAsync(EngagementDto engagement)
    {
        return _mapper.Map<EngagementDto>(await _engagementRepository.AddAsync(_mapper.Map<Engagement>(engagement)));
    }

    public async Task UpdateAsync(int id, EngagementDto engagement)
    {
        await _engagementRepository.UpdateAsync(id,_mapper.Map<Engagement>(engagement));
    }

    public async Task DeleteAsync(int id)
    {
        await _engagementRepository.DeleteAsync(id);
    }
}