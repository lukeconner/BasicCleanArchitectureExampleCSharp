using Ddp.Domain.Models;

namespace Ddp.App.Interfaces.Repository;

public interface IUserRepository : IGenericRepository<User>
{
    public Task<User?> GetByUsername(string username);
}