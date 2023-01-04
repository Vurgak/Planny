using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Planny.Application.Shared.Abstractions;
using Planny.Application.ViewModels;

namespace Planny.Application.Commands.TodoList;

public class GetTodoListsQuery : IRequest<IEnumerable<TodoListViewModel>>
{
}

public class GetTodoListsQueryHandler : IRequestHandler<GetTodoListsQuery, IEnumerable<TodoListViewModel>>
{
    private readonly IMapper _mapper;
    private readonly IApplicationDbContext _databaseContext;

    public GetTodoListsQueryHandler(IMapper mapper, IApplicationDbContext databaseContext)
    {
        _mapper = mapper;
        _databaseContext = databaseContext;
    }

    public async Task<IEnumerable<TodoListViewModel>> Handle(GetTodoListsQuery command, CancellationToken cancellationToken)
    {
        var entities = await _databaseContext.TodoLists.AsNoTracking()
            .ToListAsync(cancellationToken);

        var viewModels = _mapper.Map<IEnumerable<TodoListViewModel>>(entities);
        return viewModels;
    }
}