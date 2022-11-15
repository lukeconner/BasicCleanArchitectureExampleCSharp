using Ddp.App.Interfaces.Repository;
using Ddp.Domain.Models;

namespace Ddp.Repository.Repositories;

public class UploadRepository : IUploadRepository
{
    public Task<Upload> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<int> AddAsync(Upload entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(Upload entity)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}