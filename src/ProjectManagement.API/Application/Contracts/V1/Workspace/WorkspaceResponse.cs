namespace ProjectManagement.API.Application.Contracts.V1.Workspace;

public record WorkspaceResponse(
    Guid Id,
    string Name,
    string Description
);