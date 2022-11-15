using Ddp.App.Features.Auth.Query;
using Ddp.App.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ddp.Api.Controllers.v1;

public class AuthController : BaseApiController
{
    public AuthController(AuthService auth) : base(auth)
    {
        
    }
    
    [HttpPost]
    [Route("login")]
    public async Task<IActionResult> Login([FromBody] LoginQuery query)
    {
        return Ok(await Mediator.Send(query));
    }
}