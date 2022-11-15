using Ddp.App.Interfaces.Repository;
using Ddp.Domain.Models;

namespace Ddp.Repository.Repositories;

public class PostActivityLogRepository : IPostActivityLogRepository
{
    public Task<PostActivityLog> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<int> AddAsync(PostActivityLog entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(PostActivityLog entity)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}