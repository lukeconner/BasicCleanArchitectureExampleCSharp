using Ddp.App.Interfaces.Repository;
using Ddp.Domain.Models;

namespace Ddp.Repository.Repositories;

public class PlanRepository : IPlanRepository
{
    public Task<Plan> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<int> AddAsync(Plan entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(Plan entity)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}