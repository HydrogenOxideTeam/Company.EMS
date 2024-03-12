using Company.EMS.Models.DTOs;
using Company.EMS.Models.Entities;
using Company.EMS.Repositories.Abstractions;
using Company.EMS.Services.Abstractions;

namespace Company.EMS.Services;

public class ExampleService(IExampleRepository repository): IExampleService
{
    private readonly IExampleRepository _repository = repository;
    
    public async Task<ExampleDto> CreateExampleAsync(string name)
    {
        var newEntity = new ExampleEntity { Name = name };
        var createdEntity = await _repository.AddAsync(newEntity);

        return new ExampleDto { Id = createdEntity.Id, Name = createdEntity.Name };
    }

    public async Task<ExampleDto> GetExampleByIdAsync(int id)
    {
        var entity = await _repository.GetByIdAsync(id);
        if (entity == null) throw new KeyNotFoundException("Example not found");

        return new ExampleDto { Id = entity.Id, Name = entity.Name };
    }
}