using Microsoft.EntityFrameworkCore;
using Planny.Domain.Entities;

namespace Planny.Application.Shared.Abstractions;

public interface IApplicationDbContext
{
    DbSet<TodoListEntity> TodoLists { get; }

    DbSet<TodoItemEntity> TodoItems { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
