using AutoMapper;
using Company.EMS.Models.DTOs;
using Company.EMS.Models.Entities;
using Company.EMS.Repositories.Generic;
using Company.EMS.Services.Abstractions;

namespace Company.EMS.Services;

public class ProjectManagerService(IMapper mapper, IUnitOfWork unitOfWork): IProjectManagerService
{
    public async Task<IEnumerable<ProjectManagerDto>> GetAllAsync()
    {
        var projectManagers = await unitOfWork.ProjectManagers.GetAllAsync();
        return mapper.Map<IEnumerable<ProjectManagerDto>>(projectManagers);
    }

    public async Task<ProjectManagerDto?> GetByIdAsync(int id)
    {
        var projectManager = await unitOfWork.ProjectManagers.GetByIdAsync(id);
        return mapper.Map<ProjectManagerDto>(projectManager);
    }

    public async Task<ProjectManagerDto?> AddAsync(ProjectManagerDto? projectManagerDto)
    {
        var projectManager = mapper.Map<ProjectManager>(projectManagerDto);
        var projectManagerAdded = await unitOfWork.ProjectManagers.AddAsync(projectManager);
        await unitOfWork.CompleteAsync();
        return mapper.Map<ProjectManagerDto>(projectManagerAdded);
    }

    public async Task UpdateAsync(int id, ProjectManagerDto? projectManagerDto)
    {
        var projectManager = mapper.Map<ProjectManager>(projectManagerDto);
        await unitOfWork.ProjectManagers.UpdateAsync(id, projectManager);
        await unitOfWork.CompleteAsync();
    }

    public async Task DeleteByIdAsync(int id)
    {
        await unitOfWork.ProjectManagers.DeleteByIdAsync(id);
        await unitOfWork.CompleteAsync();
    }
}
