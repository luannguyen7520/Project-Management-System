using ProjectManagement.API.Models.Abstraction;

namespace ProjectManagement.API.Models;

public class Workspace : AuditableEntity<Guid>
{
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;


    #region Member relationships
    public List<Member> Members { get; set; } = [];
    public List<WorkspaceMember> WorkspaceMembers { get; set; } = [];
    #endregion
}
