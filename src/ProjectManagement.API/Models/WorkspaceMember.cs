namespace ProjectManagement.API.Models;

public class WorkspaceMember
{
    public Guid WorkspaceId { get; set; }
    public Guid MemberId { get; set; }
    public Guid RoleId { get; set; }
    public DateTime JoinedAt { get; set; } = DateTime.UtcNow;

    public virtual Workspace Workspace { get; set; } = default!;
    public virtual Member Member { get; set; } = default!;
    public virtual Role Role { get; set; } = default!;
}
