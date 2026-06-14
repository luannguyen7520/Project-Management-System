using ProjectManagement.API.Models.Abstraction;

namespace ProjectManagement.API.Models;

public class Project : AuditableEntity<Guid>
{
    public Guid WorkspaceId { get; set; }
    public string Code { get; set; } = default!;
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string Priority { get; set; } = default!;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal Budget { get; set; }
    public string Currency { get; set; } = "VND";
    public float ProgressPercent { get; set; } = 0.0f;
    public string Status { get; set; } = default!; // Planning, Active, OnHold, Completed, Cancelled
    public bool IsArchived { get; set; } = false;
}
