namespace ProjectManagement.API.Models;

public class ProjectMember
{
    public Guid ProjectId { get; set; }
    public Guid MemberId { get; set; }
    public DateTime JoinedDate { get; set; }
}
