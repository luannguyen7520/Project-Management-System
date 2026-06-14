using ProjectManagement.API.Models.Abstraction;

namespace ProjectManagement.API.Models;

public class Defect : AuditableEntity<Guid>
{
    public Guid ProjectId { get; set; }
    public Guid ReleaseId { get; set; }
    public Guid? AssigneeId { get; set; }
    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string Severity { get; set; } = default!; // Low, Medium, High, Critical
    public string Priority { get; set; } = default!; // Low, Medium, High, Critical
    public string Environment { get; set; } = default!; // Development, Testing, Staging, Production
    public string StepToReproduce { get; set; } = default!;
    public string ExpectedResult { get; set; } = default!;
    public string ActualResult { get; set; } = default!;
    public string Attachment { get; set; } = default!;
    public string Status { get; set; } = default!; //Reported, Assigned, InProgress, Fixed, ReadyForTesting, Verified, Closed, Reopened
}
