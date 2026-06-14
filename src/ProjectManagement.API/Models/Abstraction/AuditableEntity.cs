using System;

namespace ProjectManagement.API.Models.Abstraction;

public abstract class AuditableEntity<T> : IEntity<T>, IAuditableEntity
{
    public T Id { get; set; } = default!;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
    public Guid CreatedById { get; set; }
    public Guid? UpdatedById { get; set; }
    public Guid? DeletedById { get; set; }
}
