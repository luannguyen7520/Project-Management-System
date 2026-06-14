using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectManagement.API.Models;

namespace ProjectManagement.API.Data.Configuration;

public class WorkspaceConfiguration : IEntityTypeConfiguration<Workspace>
{
    public void Configure(EntityTypeBuilder<Workspace> builder)
    {
        builder.HasKey(w => w.Id);
        builder.HasMany(w => w.Members)
            .WithMany(m => m.Workspaces)
            .UsingEntity<WorkspaceMember>(
                "WorkspaceMember",
                r => r.HasOne(wm => wm.Member).WithMany(m => m.WorkspaceMembers).HasForeignKey(wm => wm.MemberId).HasPrincipalKey(m => m.Id),
                l => l.HasOne(wm => wm.Workspace).WithMany(w => w.WorkspaceMembers).HasForeignKey(wm => wm.WorkspaceId).HasPrincipalKey(w => w.Id),
                j => j.HasKey(wm => new {wm.WorkspaceId, wm.MemberId})
            );
    }
}
