using AutoMapper;
using MediatR;
using Planny.Application.Shared.Abstractions;
using Planny.Application.ViewModels;
using Planny.Domain.Entities;

namespace Planny.Application.Commands.TodoList;

public class CreateTodoListCommand : IRequest<GuidViewModel>
{
    public string Name { get; set; }
}

public class CreateTodoListCommandHandler : IRequestHandler<CreateTodoListCommand, GuidViewModel>
{
    private readonly IMapper _mapper;
    private readonly IApplicationDbContext _databaseContext;

    public CreateTodoListCommandHandler(IMapper mapper, IApplicationDbContext databaseContext)
    {
        _mapper = mapper;
        _databaseContext = databaseContext;
    }

    public async Task<GuidViewModel> Handle(CreateTodoListCommand command, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<TodoListEntity>(command);
        
        _databaseContext.TodoLists.Add(entity);

        await _databaseContext.SaveChangesAsync(cancellationToken);

        return new GuidViewModel(entity.Guid);
    }
}
