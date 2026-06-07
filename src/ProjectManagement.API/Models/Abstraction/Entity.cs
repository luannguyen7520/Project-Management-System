namespace ProjectManagement.API.Models.Abstraction;

public abstract class Entity<T> : IEntity<T>
{
    public T Id { get; set; } = default!;
    public string Description { get; set; } = default!;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? UpdatedAt { get; set; }
}