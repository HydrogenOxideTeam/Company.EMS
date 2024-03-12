using Company.EMS.Data;
using Company.EMS.Models.Entities;
using Company.EMS.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Company.EMS.Repositories;

public class ExampleRepository(ApplicationDbContext context): IExampleRepository
{
    private readonly ApplicationDbContext _context = context;
    
    public async Task<ExampleEntity> AddAsync(ExampleEntity entity)
    {
        await _context.ExampleEntities.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<ExampleEntity> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<ExampleEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public async Task UpdateAsync(ExampleEntity entity)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<ExampleEntity?> GetByNameAsync(string name)
    {
        return await _context.ExampleEntities
            .FirstOrDefaultAsync(e => e.Name == name);
    }
}