using Ddp.App.Services;
using Microsoft.AspNetCore.Mvc;

namespace Ddp.Api.Controllers.v1;

public class LanguageController : BaseApiController
{
    public LanguageController(AuthService auth) : base(auth)
    {
        
    }
}