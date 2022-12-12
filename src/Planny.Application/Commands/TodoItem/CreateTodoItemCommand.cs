using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Planny.Application.Shared.Abstractions;
using Planny.Application.ViewModels;
using Planny.Domain.Entities;
using Planny.Domain.Exceptions;

namespace Planny.Application.Commands.TodoItem;

public class CreateTodoItemCommand : IRequest<GuidViewModel>
{
    public Guid ListGuid { get; set; }

    public string Title { get; set; } = string.Empty;

    public string? Description { get; set; }
}

internal class CreateTodoItemCommandHandler : IRequestHandler<CreateTodoItemCommand, GuidViewModel>
{
    private readonly IMapper _mapper;
    private readonly IApplicationDbContext _dbContext;

    public CreateTodoItemCommandHandler(IMapper mapper, IApplicationDbContext dbContext)
    {
        _mapper = mapper;
        _dbContext = dbContext;
    }

    public async Task<GuidViewModel> Handle(CreateTodoItemCommand command, CancellationToken cancellationToken)
    {
        var list = await _dbContext.TodoLists.AsNoTracking()
            .FirstOrDefaultAsync(x => x.Guid == command.ListGuid, cancellationToken);

        if (list is null)
            throw new EntityNotFoundException($"List with GUID '{command.ListGuid}' was not found", command.ListGuid);

        var entity = _mapper.Map<TodoItemEntity>(command);
        entity.ListId = list.Id;

        _dbContext.TodoItems.Add(entity);

        await _dbContext.SaveChangesAsync(cancellationToken);

        return new GuidViewModel(entity.Guid);
    }
}
