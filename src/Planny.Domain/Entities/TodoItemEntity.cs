namespace Planny.Domain.Entities;

public class TodoItemEntity : PublicEntity
{
    public int ListId { get; set; }

    public string Title { get; set; } = string.Empty;
    
    public string Description { get; set; } = string.Empty;

    public TodoListEntity List { get; set; } = null!;
}
