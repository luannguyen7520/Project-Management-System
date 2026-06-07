using ProjectManagement.API.Models.Abstraction;

namespace ProjectManagement.API.Models;

public class Role : Entity<Guid>
{
    public string Name { get; set; } = default!; // Admin, WorkspaceAdmin, ProjectManager, Developer, Tester, Viewer
}
