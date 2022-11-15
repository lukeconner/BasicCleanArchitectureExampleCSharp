using Ddp.App.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ddp.Api.Controllers.v1;

public class GroupController : BaseApiController
{
    public GroupController(AuthService auth) : base(auth)
    {
        
    }
}