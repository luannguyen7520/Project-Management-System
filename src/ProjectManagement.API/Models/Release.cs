using ProjectManagement.API.Models.Abstraction;

namespace ProjectManagement.API.Models;

public class Release : AuditableEntity<Guid>
{
    public Guid ProjectId { get; set; }
    public string Version { get; set; } = default!;
    public string Status { get; set; } = default!; // Planned, InDevelopment, Testing, ReadyForRelease, Released, Cancelled
    public DateOnly ReleasedDate { get; set; }
}
