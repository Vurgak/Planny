using MediatR;
using Microsoft.AspNetCore.Mvc;
using Planny.Application.Commands.TodoList;
using Planny.Application.ViewModels;

namespace Planny.WebApi.Controllers;

public class TodoListsController : ApiController
{
    [HttpPost]
    public async Task<ActionResult<GuidViewModel>> Create(
        [FromBody] CreateTodoListCommand command,
        CancellationToken cancellationToken)
    {
        var result = await Mediator.Send(command, cancellationToken);
        return result;
    }
}
