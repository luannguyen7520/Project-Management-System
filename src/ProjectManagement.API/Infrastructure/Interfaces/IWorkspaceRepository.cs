using ProjectManagement.API.Models;

namespace ProjectManagement.API.Infrastructure.Interfaces;

public interface IWorkspaceRepository
{
    Task<Workspace> CreateWorkspaceAsync(Workspace workspace, CancellationToken ct);
    Task<bool> DeleteWorkspaceAsync(Guid id, CancellationToken ct);
    Task<Workspace> GetWorkspaceByIdAsync(Guid id, CancellationToken ct);
    IQueryable<Workspace> GetWorkspaces();
    Task<bool> UpdateWorkspaceAsync(Guid id, Workspace workspace, CancellationToken ct);
}