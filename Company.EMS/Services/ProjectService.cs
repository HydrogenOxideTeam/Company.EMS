using AutoMapper;
using Company.EMS.Models.DTOs;
using Company.EMS.Models.Entities;
using Company.EMS.Repositories.Generic;
using Company.EMS.Services.Abstractions;

namespace Company.EMS.Services;

public class ProjectService(IMapper mapper, IUnitOfWork unitOfWork): IProjectService
{
    public async Task<IEnumerable<ProjectDto>> GetAllAsync()
    {
        var projects = await unitOfWork.Projects.GetAllAsync();
        return mapper.Map<IEnumerable<ProjectDto>>(projects);
    }

    public async Task<ProjectDto?> GetByIdAsync(int id)
    {
        var project = await unitOfWork.Projects.GetByIdAsync(id);
        return mapper.Map<ProjectDto>(project);
    }

    public async Task<ProjectDto?> AddAsync(ProjectDto? projectDto)
    {
        var project = mapper.Map<Project>(projectDto);
        var projectAdded = await unitOfWork.Projects.AddAsync(project);
        await unitOfWork.CompleteAsync();
        return mapper.Map<ProjectDto>(projectAdded);
    }

    public async Task UpdateAsync(int id, ProjectDto? projectDto)
    {
        var project = mapper.Map<Project>(projectDto);
        await unitOfWork.Projects.UpdateAsync(id, project);
        await unitOfWork.CompleteAsync();
    }

    public async Task DeleteByIdAsync(int id)
    {
        await unitOfWork.Projects.DeleteByIdAsync(id);
        await unitOfWork.CompleteAsync();
    }
}
