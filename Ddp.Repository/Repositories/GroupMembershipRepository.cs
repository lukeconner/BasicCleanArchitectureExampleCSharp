using Ddp.App.Interfaces.Repository;
using Ddp.Domain.Models;

namespace Ddp.Repository.Repositories;

public class GroupMembershipRepository : IGroupMembershipRepository
{
    public Task<GroupMembership> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<int> AddAsync(GroupMembership entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(GroupMembership entity)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}