namespace Planny.Domain.Exceptions;

public class EntityNotFoundException : Exception
{
    public Guid Guid { get; init; }

    public EntityNotFoundException(string message, Guid guid) : base(message)
    {
        Guid = guid;
    }
}
