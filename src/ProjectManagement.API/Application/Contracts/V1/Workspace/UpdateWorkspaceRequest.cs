namespace ProjectManagement.API.Application.Contracts.V1.Workspace;

public record UpdateWorkspaceRequest(
    string Name,
    string Description,
    bool IsPrivate
);