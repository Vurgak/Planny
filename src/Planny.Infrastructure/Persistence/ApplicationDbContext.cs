using Microsoft.EntityFrameworkCore;
using Planny.Domain.Entities;
using Planny.Infrastructure.Persistence.EntityBuilders;

namespace Planny.Infrastructure.Persistence;

internal class ApplicationDbContext : DbContext
{

	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
	{
    }

    public DbSet<TodoListEntity> TodoLists { get; set; }
    public DbSet<TodoItemEntity> TodoItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TodoListEntity>().Configure();
        modelBuilder.Entity<TodoItemEntity>().Configure();
    }
}
