using Ddp.App.Interfaces.Repository;
using Ddp.Domain.Models;

namespace Ddp.Repository.Repositories;

public class OrganizationTypeRepository : IOrganizationTypeRepository
{
    public Task<OrganizationType> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<int> AddAsync(OrganizationType entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(OrganizationType entity)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}