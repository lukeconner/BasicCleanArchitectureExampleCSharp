namespace Ddp.App.Interfaces;


public interface IGenericRepository<T> where T : class
{
    Task<T> GetByIdAsync(int id);
    Task<int> AddAsync(T entity);
    Task<bool> UpdateAsync(T entity);
    Task<int> DeleteAsync(int id);
}
