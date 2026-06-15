using ProjectManagement.API.Application.Contracts.V1.Workspace;

namespace ProjectManagement.API.Application.Interfaces;

public interface IWorkspaceService
{
    Task<WorkspaceResponse> CreateWorkspaceAsync(CreateWorkspaceRequest request, CancellationToken ct);
    Task<DeleteWorkspaceResponse> DeleteWorkspaceAsync(Guid id, CancellationToken ct);
    Task<WorkspaceResponse> GetWorkspaceByIdAsync(Guid id, CancellationToken ct);
    Task<List<WorkspaceResponse>> GetWorkspacesAsync(CancellationToken ct);
    Task<UpdateWorkspaceResponse> UpdateWorkspaceAsync(Guid id, UpdateWorkspaceRequest request, CancellationToken ct);
}