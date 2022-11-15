using System.Security.Claims;
using Ddp.Domain.Models;

namespace Ddp.App.Services;

public class AuthService
{
    public User GetCurrentUser(ClaimsPrincipal user)
    {
        //Implement based on authentication type
        return new User();
    }
}