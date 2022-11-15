using Ddp.App.Interfaces.Repository;
using Ddp.Domain.Models;

namespace Ddp.Repository.Repositories;

public class GroupTypeRepository : IGroupTypeRepository
{
    public Task<GroupType> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<int> AddAsync(GroupType entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(GroupType entity)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}