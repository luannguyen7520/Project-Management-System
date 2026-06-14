using ProjectManagement.API.Models.Abstraction;

namespace ProjectManagement.API.Models;

public class ChangeRequest : AuditableEntity<Guid>
{
    public Guid ProjectId { get; set; }
    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string Category { get; set; } = default!; // FeatureEnhancement, RequirementChange, TechnicalChange, SecurityChange, ComplianceChange
    public int EstimatedHours { get; set; }
    public string CostImpact { get; set; } = default!; // low, medium, high, critical
    public string SchedualImpact { get; set; } = default!; // low, medium, high, critical
    public string RiskImpace { get; set; } = default!; // low, medium, high, critical
    public string Status { get; set; } = default!; // Draft, Submitted, UnderReview, Approved, Rejected, Implemented, Closed
}
