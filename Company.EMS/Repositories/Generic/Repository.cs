using Company.EMS.Data;
using Microsoft.EntityFrameworkCore;

namespace Company.EMS.Repositories.Generic;

public class Repository<T>(ApplicationDbContext context): IRepository<T> where T: class
{
    protected readonly ApplicationDbContext Context = context;
    protected readonly DbSet<T> DbSet = context.Set<T>();
    public async Task<T?> GetByIdAsync(int id)
    {
        return await DbSet.FindAsync(id);
    }

    public async Task<List<T>?> GetAllAsync()
    {
        return await DbSet.ToListAsync();
    }

    public async Task<T> AddAsync(T? entity)
    {
        if (entity == null) throw new ArgumentNullException(nameof(entity));
        
        await DbSet.AddAsync(entity);
        
        return entity;
    }
    public async Task UpdateAsync(int id, T? entity)
    {
        var existingEntity = await GetByIdAsync(id);
        
        if (entity == null || existingEntity == null) throw new ArgumentNullException(nameof(entity));
        
        var entityType = Context.Model.FindEntityType(typeof(T));
        var key = entityType!.FindPrimaryKey();
        var idProperty = key!.Properties[0];
        
        idProperty.PropertyInfo!.SetValue(entity, id);
        
        Context.Entry(existingEntity).CurrentValues.SetValues(entity);
        Context.Entry(existingEntity).State = EntityState.Modified;
    }

    public async Task DeleteByIdAsync(int id)
    {
        var entity = await GetByIdAsync(id);
        
        if (entity == null) throw new ArgumentException($"Entity with {id} is not found");
        
        DbSet.Remove(entity);
    }
}