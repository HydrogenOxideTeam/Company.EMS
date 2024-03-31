using AutoMapper;
using Company.EMS.Models.DTOs;
using Company.EMS.Models.Entities;
using Company.EMS.Repositories.Abstractions;
using Company.EMS.Services.Abstractions;

namespace Company.EMS.Services;

public class AssignmentService(IMapper mapper, IAssignmentRepository assignmentRepository): IAssignmentService
{
    private readonly IMapper _mapper = mapper;
    private readonly IAssignmentRepository _assignmentRepository = assignmentRepository;
    
    public async Task<List<AssignmentDto>> GetAllAsync()
    {
        return _mapper.Map<List<AssignmentDto>>((await _assignmentRepository.GetAllAsync())?.ToList());
    }

    public async Task<AssignmentDto> GetByIdAsync(int id)
    {
        return _mapper.Map<AssignmentDto>(await _assignmentRepository.GetByIdAsync(id));
    }

    public async Task<AssignmentDto> AddAsync(AssignmentDto assignment)
    {
        return _mapper.Map<AssignmentDto>(await _assignmentRepository.AddAsync(_mapper.Map<Assignment>(assignment)));
    }

    public async Task UpdateAsync(AssignmentDto assignment)
    {
        await _assignmentRepository.UpdateAsync(_mapper.Map<Assignment>(assignment));
    }

    public async Task DeleteAsync(int id)
    {
        await _assignmentRepository.DeleteAsync(id);
    }
}