using ProjectManagement.API.Models.Abstraction;

namespace ProjectManagement.API.Models;

public class Project : Entity<Guid>
{
    public Guid WorkspaceId { get; set; }
    public string Code { get; set; } = default!;
    public string Name { get; set; } = default!;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Status { get; set; } = default!; // Planning, Active, Completed, Archived
}
