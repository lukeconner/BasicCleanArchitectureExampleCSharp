using Ddp.App.Interfaces.Repository;
using Ddp.Domain.Models;

namespace Ddp.Repository.Repositories;

public class UploadTypeRepository : IUploadTypeRepository
{
    public Task<UploadType> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<int> AddAsync(UploadType entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(UploadType entity)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}