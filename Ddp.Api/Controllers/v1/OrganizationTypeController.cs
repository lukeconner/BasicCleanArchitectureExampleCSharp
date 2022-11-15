using Ddp.App.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ddp.Api.Controllers.v1;

public class OrganizationTypeController : BaseApiController
{
    public OrganizationTypeController(AuthService auth) : base(auth)
    {
        
    }
}