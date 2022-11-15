using Ddp.App.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ddp.Api.Controllers.v1;

public class UserController : BaseApiController
{
    public UserController(AuthService auth) : base(auth)
    {
        
    }
}