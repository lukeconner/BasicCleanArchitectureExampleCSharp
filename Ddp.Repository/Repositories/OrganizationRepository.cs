using Ddp.App.Interfaces.Repository;
using Ddp.Domain.Models;

namespace Ddp.Repository.Repositories;

public class OrganizationRepository : IOrganizationRepository
{
    public Task<Organization> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<int> AddAsync(Organization entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(Organization entity)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}