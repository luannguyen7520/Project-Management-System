using Mapster;

using Microsoft.EntityFrameworkCore;

using ProjectManagement.API.Application.Contracts.V1.Workspace;
using ProjectManagement.API.Application.Interfaces;
using ProjectManagement.API.Infrastructure.Interfaces;
using ProjectManagement.API.Models;

namespace ProjectManagement.API.Application.Services;

public class WorkspaceService(IWorkspaceRepository repository) : IWorkspaceService
{
    public async Task<WorkspaceResponse> CreateWorkspaceAsync(CreateWorkspaceRequest request, CancellationToken ct)
    {
        var workspace = request.Adapt<Workspace>();
        var response = await repository.CreateWorkspaceAsync(workspace, ct);

        return response.Adapt<WorkspaceResponse>();
    }

    public async Task<DeleteWorkspaceResponse> DeleteWorkspaceAsync(Guid id, CancellationToken ct)
    {
        var result = await repository.DeleteWorkspaceAsync(id, ct);

        return new DeleteWorkspaceResponse(result);
    }

    public async Task<WorkspaceResponse> GetWorkspaceByIdAsync(Guid id, CancellationToken ct)
    {
        var workspace = await repository.GetWorkspaceByIdAsync(id, ct);

        return workspace.Adapt<WorkspaceResponse>();
    }

    public async Task<List<WorkspaceResponse>> GetWorkspacesAsync(CancellationToken ct)
    {
        var workspaces = await repository.GetWorkspaces().ToListAsync(ct);

        return workspaces.Adapt<List<WorkspaceResponse>>();
    }

    public async Task<UpdateWorkspaceResponse> UpdateWorkspaceAsync(Guid id, UpdateWorkspaceRequest request, CancellationToken ct)
    {
        var workspace = request.Adapt<Workspace>();
        var result = await repository.UpdateWorkspaceAsync(id, workspace, ct);

        return new UpdateWorkspaceResponse(result);
    }
}