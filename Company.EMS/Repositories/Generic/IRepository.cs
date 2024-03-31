using Company.EMS.Data;

namespace Company.EMS.Repositories.Generic;

public interface IRepository<T> where T: class
{
    Task<T> AddAsync(T entity);
    Task<T?> GetByIdAsync(int id);
    Task<IEnumerable<T>?> GetAllAsync();
    Task UpdateAsync(T entity);
    Task DeleteAsync(int id);
}