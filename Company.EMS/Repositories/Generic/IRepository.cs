using Company.EMS.Data;

namespace Company.EMS.Repositories.Generic;

public interface IRepository<T> where T: class
{
    Task<T?> GetByIdAsync(int id);
    Task<List<T>?> GetAllAsync();
    Task<T> AddAsync(T? entity);
    Task UpdateAsync(int id, T? entity);
    Task DeleteByIdAsync(int id);
}