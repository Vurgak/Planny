using AutoMapper;
using Planny.Application.Commands.TodoItem;
using Planny.Application.MappingProfiles;
using Planny.Domain.Entities;

namespace Planny.Application.UnitTests.MappingProfiles;

public class TodoItemMappingProfileTests : MappingProfileTests<TodoItemMappingProfile>
{
    [Fact]
    public void Map_ShouldHaveValidConfiguration()
    {
        Configuration.AssertConfigurationIsValid();
    }

    [Theory]
    [InlineData(typeof(CreateTodoItemCommand), typeof(TodoItemEntity))]
    public void Map_ShouldSupportMappingFromSourceToDestination(Type source, Type destination)
    {
        var instance = GetInstanceOf(source);

        Mapper.Map(instance, source, destination);
    }
}
