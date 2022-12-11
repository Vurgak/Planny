using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Planny.Domain.Entities;

namespace Planny.Infrastructure.Persistence.EntityBuilders;

internal static class TodoListEntityBuilderExtensions
{
    public static void Configure(this EntityTypeBuilder<TodoListEntity> entityBuilder)
    {
        entityBuilder.ToTable("TodoList");
     
        entityBuilder.Property(x => x.Name)
            .HasMaxLength(100);
    }
}
