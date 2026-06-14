using Microsoft.AspNetCore.Identity;

using ProjectManagement.API.Models.Abstraction;
using ProjectManagement.API.Models.Enums;

namespace ProjectManagement.API.Models;

public class Member : Entity<Guid>
{
    public string FullName { get; set; } = default!;
    public string? AvatarUrl { get; set; }
    public UserStatus Status { get; set; } = UserStatus.Active;
    public DateTime LastLoginAt { get; set; }

    #region Workspace relationships
    public List<Workspace> Workspaces { get; set; } = [];
    public List<WorkspaceMember> WorkspaceMembers { get; set; } = [];
    #endregion
}
