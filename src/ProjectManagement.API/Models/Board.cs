using ProjectManagement.API.Models.Abstraction;

namespace ProjectManagement.API.Models;

public class Board : Entity<Guid>
{
    public Guid ProjectId { get; set; }
    public string Name { get; set; } = default!;
}
