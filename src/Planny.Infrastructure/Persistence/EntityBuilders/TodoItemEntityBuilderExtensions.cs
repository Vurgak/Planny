using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Planny.Domain.Entities;

namespace Planny.Infrastructure.Persistence.EntityBuilders;

internal static class TodoItemEntityBuilderExtensions
{
    public static void Configure(this EntityTypeBuilder<TodoItemEntity> entityBuilder)
    {
        entityBuilder.ToTable("TodoItem");

        entityBuilder.Property(p => p.Guid)
            .HasDefaultValueSql("NEWID()");

        entityBuilder.Property(x => x.Title)
            .HasMaxLength(100);

        entityBuilder.Property(x => x.Description)
            .HasMaxLength(2000);

        entityBuilder.HasIndex(x => x.Guid)
            .IsUnique();
    }
}
