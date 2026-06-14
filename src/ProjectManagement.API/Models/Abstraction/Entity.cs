namespace ProjectManagement.API.Models.Abstraction;

public abstract class Entity<T> : IEntity<T>
{
    public T Id { get; set; } = default!;
}