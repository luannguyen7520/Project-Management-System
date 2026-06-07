namespace ProjectManagement.API.Models;

public class WorkspaceMember
{
    public Guid WorkspaceId { get; set; }
    public Guid MemberId { get; set; }
    public Guid RoleId { get; set; }
    public DateTime JoinedAt { get; set; } = DateTime.Now;
}
