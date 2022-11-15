using Ddp.App.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ddp.Api.Controllers.v1;

public class PostActivityLogController : BaseApiController
{
    public PostActivityLogController(AuthService auth) : base(auth)
    {
        
    }
}