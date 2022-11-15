using Ddp.App.Services;
using Ddp.Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ddp.Api.Controllers;


[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
public abstract class BaseApiController : ControllerBase
{
    private IMediator? _mediator;
    protected IMediator? Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

    private readonly AuthService _auth;
    private User _currentUser;
    protected User currentUser
    {
        get { return _currentUser ??= _auth.GetCurrentUser(User); }
    }

    protected BaseApiController(AuthService auth)
    {
        _auth = auth;
    }
}
