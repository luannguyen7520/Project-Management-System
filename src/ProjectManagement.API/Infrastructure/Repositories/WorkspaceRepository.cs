using Microsoft.EntityFrameworkCore;

using ProjectManagement.API.Infrastructure.Interfaces;
using ProjectManagement.API.Models;

namespace ProjectManagement.API.Infrastructure.Repositories;

public class WorkspaceRepository(PMSystemDbContext dbContext) : IWorkspaceRepository
{
    public async Task<Workspace> CreateWorkspaceAsync(Workspace workspace, CancellationToken ct)
    {
        //  workspace.CreatedById = ""
        await dbContext.AddAsync(workspace, ct);
        await dbContext.SaveChangesAsync(ct);

        return workspace;
    }

    public async Task<bool> DeleteWorkspaceAsync(Guid id, CancellationToken ct)
    {
        var workspace = await dbContext.Workspaces.FirstOrDefaultAsync(w => w.Id == id, ct)
            ?? throw new Exception("Not Found");

        dbContext.Workspaces.Remove(workspace);
        await dbContext.SaveChangesAsync(ct);

        return true;
    }

    public async Task<Workspace> GetWorkspaceByIdAsync(Guid id, CancellationToken ct)
    {
        var workspace = await dbContext.Workspaces.FirstOrDefaultAsync(w => w.Id == id, ct)
            ?? throw new Exception("Not Found");

        return workspace;
    }

    public IQueryable<Workspace> GetWorkspaces()
    {
        return dbContext.Workspaces.AsQueryable();
    }

    public async Task<bool> UpdateWorkspaceAsync(Guid id, Workspace workspace, CancellationToken ct)
    {
        var existingWorkspace = await dbContext.Workspaces.FirstOrDefaultAsync(w => w.Id == id, ct)
            ?? throw new Exception("Not Found");

        existingWorkspace.Name = workspace.Name;
        existingWorkspace.Description = workspace.Description;
        existingWorkspace.UpdatedAt = DateTime.UtcNow;
        // existingWorkspace.UpdatedById

        return true;
    }
}