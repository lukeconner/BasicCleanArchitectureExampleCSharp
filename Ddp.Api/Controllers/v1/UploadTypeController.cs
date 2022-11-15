using Ddp.App.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ddp.Api.Controllers.v1;

public class UploadTypeController : BaseApiController
{
    public UploadTypeController(AuthService auth) : base(auth)
    {
        
    }
    
}