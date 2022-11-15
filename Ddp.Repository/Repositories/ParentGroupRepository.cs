using Ddp.App.Interfaces.Repository;
using Ddp.Domain.Models;

namespace Ddp.Repository.Repositories;

public class ParentGroupRepository : IParentGroupRepository
{
    public Task<ParentGroup> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<int> AddAsync(ParentGroup entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(ParentGroup entity)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}