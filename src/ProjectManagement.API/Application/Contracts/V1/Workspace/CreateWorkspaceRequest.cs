namespace ProjectManagement.API.Application.Contracts.V1.Workspace;

public record CreateWorkspaceRequest(
    string Name,
    string Description,
    bool IsPrivate
);