using Ddp.App.Interfaces.Repository;
using Ddp.Repository.Models;
using Ddp.Repository.Services;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using User = Ddp.Domain.Models.User;

namespace Ddp.Repository.Repositories;

public class UserRepository : IUserRepository
{
    private readonly DdpContext _db;

    public UserRepository()
    {
        _db = ContextService.GetContext();
    }
    
    public async Task<User> GetByIdAsync(int id)
    {
        return await (from u in _db.Users
            where u.Id == id
            select new User
            {
                Id = u.Id,
                Active = u.Active,
                Admin = u.Active,
                Email = u.Email,
                Password = u.Password,
                Salt = u.Salt,
                DisplayName = u.DisplayName,
                FirstName = u.FirstName,
                LastName = u.LastName,
                PrimaryLanguageId = u.PrimaryLanguageId
            }).FirstOrDefaultAsync();
    }

    public Task<int> AddAsync(User entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> UpdateAsync(User entity)
    {
        throw new NotImplementedException();
    }

    public Task<int> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<User?> GetByUsername(string username)
    {
        return await (from u in _db.Users
            where u.Email == username
            select new User
            {
                Id = u.Id,
                Active = u.Active,
                Admin = u.Active,
                Email = u.Email,
                Password = u.Password,
                Salt = u.Salt,
                DisplayName = u.DisplayName,
                FirstName = u.FirstName,
                LastName = u.LastName,
                PrimaryLanguageId = u.PrimaryLanguageId
            }).FirstOrDefaultAsync();
    }
}