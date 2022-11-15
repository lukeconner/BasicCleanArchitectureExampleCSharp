using Ddp.App.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ddp.Api.Controllers.v1;

public class UploadController : BaseApiController
{
    public UploadController(AuthService auth) : base(auth)
    {
        
    }
}