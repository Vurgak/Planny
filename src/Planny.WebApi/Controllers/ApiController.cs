using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Planny.WebApi.Controllers;

[ApiController]
[Route("/Api/[controller]")]
public abstract class ApiController : ControllerBase
{
    private ISender _mediator = null!;

    protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();
}
