using Ddp.App.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ddp.Api.Controllers.v1;

public class OrganizationController : BaseApiController
{
    public OrganizationController(AuthService auth) : base(auth)
    {
        
    }
}