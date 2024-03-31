using AutoMapper;
using Company.EMS.Models.DTOs;
using Company.EMS.Models.Entities;
using Company.EMS.Repositories.Abstractions;
using Company.EMS.Services.Abstractions;

namespace Company.EMS.Services;

public class DeveloperService(IMapper mapper, IDeveloperRepository developerRepository): IDeveloperService
{
    private readonly IMapper _mapper = mapper;
    private readonly IDeveloperRepository _developerRepository = developerRepository;
    
    public async Task<List<DeveloperDto>> GetAllAsync()
    {
        return _mapper.Map<List<DeveloperDto>>((await _developerRepository.GetAllAsync())?.ToList());
    }

    public async Task<DeveloperDto> GetByIdAsync(int id)
    {
        return _mapper.Map<DeveloperDto>(await _developerRepository.GetByIdAsync(id));
    }

    public async Task<DeveloperDto> AddAsync(DeveloperDto developer)
    {
        return _mapper.Map<DeveloperDto>(await _developerRepository.AddAsync(_mapper.Map<Developer>(developer)));
    }

    public async Task UpdateAsync(DeveloperDto developer)
    {
        await _developerRepository.UpdateAsync(_mapper.Map<Developer>(developer));
    }

    public async Task DeleteAsync(int id)
    {
        await _developerRepository.DeleteAsync(id);
    }
}