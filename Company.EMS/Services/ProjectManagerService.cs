using AutoMapper;
using Company.EMS.Models.DTOs;
using Company.EMS.Models.Entities;
using Company.EMS.Repositories.Abstractions;
using Company.EMS.Services.Abstractions;

namespace Company.EMS.Services;

public class ProjectManagerService(IMapper mapper, IProjectManagerRepository projectManagerRepository): IProjectManagerService
{
    private readonly IMapper _mapper = mapper;
    private readonly IProjectManagerRepository _projectManagerRepository = projectManagerRepository;
    
    public async Task<List<ProjectManagerDto>> GetAllAsync()
    {
        return _mapper.Map<List<ProjectManagerDto>>((await _projectManagerRepository.GetAllAsync())?.ToList());
    }

    public async Task<ProjectManagerDto> GetByIdAsync(int id)
    {
        return _mapper.Map<ProjectManagerDto>(await _projectManagerRepository.GetByIdAsync(id));
    }

    public async Task<ProjectManagerDto> AddAsync(ProjectManagerDto projectManager)
    {
        return _mapper.Map<ProjectManagerDto>(await _projectManagerRepository.AddAsync(_mapper.Map<ProjectManager>(projectManager)));
    }

    public async Task UpdateAsync(int id, ProjectManagerDto projectManager)
    {
        await _projectManagerRepository.UpdateAsync(id,_mapper.Map<ProjectManager>(projectManager));
    }

    public async Task DeleteAsync(int id)
    {
        await _projectManagerRepository.DeleteAsync(id);
    }
}