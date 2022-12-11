namespace Planny.Domain.Entities;

public class TodoListEntity : PublicEntity
{
    public string Name { get; set; }

    public ICollection<TodoItemEntity> Items { get; set; } = new List<TodoItemEntity>();
}
