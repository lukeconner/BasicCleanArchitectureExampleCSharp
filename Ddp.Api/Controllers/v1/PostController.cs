using Ddp.App.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ddp.Api.Controllers.v1;

public class PostController : BaseApiController
{
    public PostController(AuthService auth) : base(auth)
    {
        
    }
}