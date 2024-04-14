using AutoMapper;
using Company.EMS.Models.DTOs;
using Company.EMS.Models.Entities;
using Company.EMS.Repositories.Generic;
using Company.EMS.Services.Abstractions;

namespace Company.EMS.Services;

public class DeveloperService(IMapper mapper, IUnitOfWork unitOfWork): IDeveloperService
{
    public async Task<IEnumerable<DeveloperDto>> GetAllAsync()
    {
        var developers = await unitOfWork.Developers.GetAllAsync();
        
        return mapper.Map<IEnumerable<DeveloperDto>>(developers);
    }

    public async Task<DeveloperDto?> GetByIdAsync(int id)
    {
        var developer = await unitOfWork.Developers.GetByIdAsync(id);
        return mapper.Map<DeveloperDto>(developer);
    }

    public async Task<DeveloperDto?> AddAsync(DeveloperDto? developerDto)
    {
        var developer = mapper.Map<Developer>(developerDto);
        var developerAdded = await unitOfWork.Developers.AddAsync(developer);
        
        await unitOfWork.CompleteAsync();
       
        return mapper.Map<DeveloperDto>(developerAdded);
    }

    public async Task UpdateAsync(int id, DeveloperDto? developerDto)
    {
        var developer = mapper.Map<Developer>(developerDto);
        
        await unitOfWork.Developers.UpdateAsync(id, developer);
        await unitOfWork.CompleteAsync();
    }

    public async Task DeleteByIdAsync(int id)
    {
        await unitOfWork.Developers.DeleteByIdAsync(id);
        await unitOfWork.CompleteAsync();
    }
}
