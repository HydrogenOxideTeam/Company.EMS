using AutoMapper;
using Company.EMS.Models.DTOs;
using Company.EMS.Models.Entities;
using Company.EMS.Repositories.Generic;
using Company.EMS.Services.Abstractions;

namespace Company.EMS.Services;

public class EngagementService(IMapper mapper, IUnitOfWork unitOfWork): IEngagementService
{
    public async Task<IEnumerable<EngagementDto>> GetAllAsync()
    {
        var engagements = await unitOfWork.Engagements.GetAllAsync();
        return mapper.Map<IEnumerable<EngagementDto>>(engagements);
    }

    public async Task<EngagementDto?> GetByIdAsync(int id)
    {
        var engagement = await unitOfWork.Engagements.GetByIdAsync(id);
        return mapper.Map<EngagementDto>(engagement);
    }

    public async Task<EngagementDto?> AddAsync(EngagementDto? engagementDto)
    {
        var engagement = mapper.Map<Engagement>(engagementDto);
        var engagementAdded = await unitOfWork.Engagements.AddAsync(engagement);
        await unitOfWork.CompleteAsync();
        return mapper.Map<EngagementDto>(engagementAdded);
    }

    public async Task UpdateAsync(int id, EngagementDto? engagementDto)
    {
        var engagement = mapper.Map<Engagement>(engagementDto);
        await unitOfWork.Engagements.UpdateAsync(id, engagement);
        await unitOfWork.CompleteAsync();
    }

    public async Task DeleteByIdAsync(int id)
    {
        await unitOfWork.Engagements.DeleteByIdAsync(id);
        await unitOfWork.CompleteAsync();
    }
}
