using Microsoft.AspNetCore.Mvc;
using Planny.Application.Commands.TodoItem;
using Planny.Application.Commands.TodoList;
using Planny.Application.ViewModels;

namespace Planny.WebApi.Controllers;

public class TodoItemsController : ApiController
{
    [HttpPost]
    public async Task<ActionResult<GuidViewModel>> Create(
        [FromBody] CreateTodoItemCommand command,
        CancellationToken cancellationToken)
    {
        var result = await Mediator.Send(command, cancellationToken);
        return result;
    }
}
