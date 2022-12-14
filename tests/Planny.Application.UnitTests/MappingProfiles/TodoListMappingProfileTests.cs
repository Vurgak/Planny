using Planny.Application.Commands.TodoList;
using Planny.Application.MappingProfiles;
using Planny.Application.ViewModels;
using Planny.Domain.Entities;

namespace Planny.Application.UnitTests.MappingProfiles;

public class TodoListMappingProfileTests : MappingProfileTests<TodoListMappingProfile>
{
    [Fact]
    public void Map_ShouldHaveValidConfiguration()
    {
        Configuration.AssertConfigurationIsValid();
    }

    [Theory]
    [InlineData(typeof(CreateTodoListCommand), typeof(TodoListEntity))]
    [InlineData(typeof(TodoListEntity), typeof(TodoListViewModel))]
    public void Map_ShouldSupportMappingFromSourceToDestination(Type source, Type destination)
    {
        var instance = GetInstanceOf(source);

        Mapper.Map(instance, source, destination);
    }
}
