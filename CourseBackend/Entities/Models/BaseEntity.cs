namespace Entities.Models;

public abstract class BaseEntity<T>
{
    public T Id { get; set; }
}
