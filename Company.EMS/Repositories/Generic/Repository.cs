using Company.EMS.Data;
using Microsoft.EntityFrameworkCore;

namespace Company.EMS.Repositories.Generic;

public class Repository<T>: IRepository<T> where T: class
{ 
    private readonly ApplicationDbContext _context;
    private readonly DbSet<T> _dbSet;
    
    protected Repository(ApplicationDbContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }
    public async Task<T> AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
        return entity;
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task<IEnumerable<T>?> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public void Update(T entity)
    {
        _dbSet.Attach(entity);
        _context.Entry(entity).State = EntityState.Modified;
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await GetByIdAsync(id);
        if (entity != null)
        {
            _dbSet.Remove(entity);
        }
    }
}