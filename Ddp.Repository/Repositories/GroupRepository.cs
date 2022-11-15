using System.Configuration;
using Ddp.App.Interfaces.Repository;
using Ddp.Repository.Models;
using Ddp.Repository.Services;
using Group = Ddp.Domain.Models.Group;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;


namespace Ddp.Repository.Repositories;

public class GroupRepository : IGroupRepository
{
    public Task<Group> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<int> AddAsync(Group entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(Group entity)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}