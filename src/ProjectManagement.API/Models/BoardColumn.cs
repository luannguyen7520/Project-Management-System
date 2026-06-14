using ProjectManagement.API.Models.Abstraction;

namespace ProjectManagement.API.Models;

public class BoardColumn : Entity<Guid>
{
    public Guid ProjectId { get; set; }
    public string Name { get; set; } = default!;
    public int Position { get; set; }
    public string? Color { get; set; }
}
