using AutoMapper;
using Company.EMS.Models.DTOs;
using Company.EMS.Models.Entities;
using Company.EMS.Repositories.Generic;
using Company.EMS.Services.Abstractions;

namespace Company.EMS.Services;
public class SalesManagerService(IMapper mapper, IUnitOfWork unitOfWork): ISalesManagerService
{
    public async Task<IEnumerable<SalesManagerDto>> GetAllAsync()
    {
        var salesManagers = await unitOfWork.SalesManagers.GetAllAsync();
        return mapper.Map<IEnumerable<SalesManagerDto>>(salesManagers);
    }

    public async Task<SalesManagerDto?> GetByIdAsync(int id)
    {
        var salesManager = await unitOfWork.SalesManagers.GetByIdAsync(id);
        return mapper.Map<SalesManagerDto>(salesManager);
    }

    public async Task<SalesManagerDto?> AddAsync(SalesManagerDto? salesManagerDto)
    {
        var salesManager = mapper.Map<SalesManager>(salesManagerDto);
        var salesManagerAdded = await unitOfWork.SalesManagers.AddAsync(salesManager);
        await unitOfWork.CompleteAsync();
        return mapper.Map<SalesManagerDto>(salesManagerAdded);
    }

    public async Task UpdateAsync(int id, SalesManagerDto? salesManagerDto)
    {
        var salesManager = mapper.Map<SalesManager>(salesManagerDto);
        await unitOfWork.SalesManagers.UpdateAsync(id, salesManager);
        await unitOfWork.CompleteAsync();
    }

    public async Task DeleteByIdAsync(int id)
    {
        await unitOfWork.SalesManagers.DeleteByIdAsync(id);
        await unitOfWork.CompleteAsync();
    }
}
