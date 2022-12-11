using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Planny.Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Emit;

namespace Planny.Infrastructure.Persistence.EntityBuilders;

internal static class TodoListEntityBuilderExtensions
{
    public static void Configure(this EntityTypeBuilder<TodoListEntity> entityBuilder)
    {
        entityBuilder.ToTable("TodoList");

        entityBuilder.Property(p => p.Guid)
            .HasDefaultValueSql("NEWID()");

        entityBuilder.Property(x => x.Name)
            .HasMaxLength(100);

        entityBuilder.HasIndex(x => x.Guid)
            .IsUnique();
    }
}
