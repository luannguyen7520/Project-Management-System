using ProjectManagement.API.Models.Abstraction;

namespace ProjectManagement.API.Models;

public class WorkItem : Entity<Guid>
{
    public Guid ProjectId { get; set; }
    public Guid? ChangeRequestId { get; set; }
    public Guid CreatedById { get; set; }
    public Guid ParentWorkItemId { get; set; }
    public string Title { get; set; } = default!;
    public string Priority { get; set; } = default!; // low, medium, high, critical
    public string Status { get; set; } = default!; // Backlog, Todo, InProgress, Review, Done, Cancelled
    public int EstimatedHours { get; set; }
    public DateTime DueDate { get; set; }
}
