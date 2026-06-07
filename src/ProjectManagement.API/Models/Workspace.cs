using ProjectManagement.API.Models.Abstraction;

namespace ProjectManagement.API.Models;

public class Workspace : Entity<Guid>
{
    public Guid OwnerId { get; set; }
    public string Name { get; set; } = default!;
}
