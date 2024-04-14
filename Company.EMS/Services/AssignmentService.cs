using AutoMapper;
using Company.EMS.Models.DTOs;
using Company.EMS.Models.Entities;
using Company.EMS.Repositories.Generic;
using Company.EMS.Services.Abstractions;

namespace Company.EMS.Services;

public class AssignmentService(IMapper mapper, IUnitOfWork unitOfWork) : IAssignmentService
{
    public async Task<IEnumerable<AssignmentDto>> GetAllAsync()
    {
        var assignments = await unitOfWork.Assignments.GetAllAsync();
        
        return mapper.Map<IEnumerable<AssignmentDto>>(assignments);
    }

    public async Task<AssignmentDto?> GetByIdAsync(int id)
    {
        var assignment = await unitOfWork.Assignments.GetByIdAsync(id);
        
        return mapper.Map<AssignmentDto>(assignment);
    }

    public async Task<AssignmentDto?> AddAsync(AssignmentDto? assignmentDto)
    {
        var assignment = mapper.Map<Assignment>(assignmentDto);
        var assignmentAdded = await unitOfWork.Assignments.AddAsync(assignment);
        
        await unitOfWork.CompleteAsync();
        
        return mapper.Map<AssignmentDto>(assignmentAdded);
    }

    public async Task UpdateAsync(int id, AssignmentDto? assignmentDto)
    {
        var assignment = mapper.Map<Assignment>(assignmentDto);
        await unitOfWork.Assignments.UpdateAsync(id, assignment);
        
        await unitOfWork.CompleteAsync();
    }

    public async Task DeleteByIdAsync(int id)
    {
        await unitOfWork.Assignments.DeleteByIdAsync(id);
        
        await unitOfWork.CompleteAsync();
    }
}