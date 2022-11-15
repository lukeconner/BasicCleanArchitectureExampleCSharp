using Ddp.App.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ddp.Api.Controllers.v1;

public class GroupTypeController : BaseApiController
{
    public GroupTypeController(AuthService auth) : base(auth)
    {
        
    }
}