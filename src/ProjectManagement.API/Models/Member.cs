using System;
using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;
using ProjectManagement.API.Models.Abstraction;

namespace ProjectManagement.API.Models;

public class Member : Entity<Guid>
{
    public string FullName { get; set; } = default!;
    public string AvatarUrl { get; set; } = default!;
    public string Status { get; set; } = default!; // Active, Inactive, Locked, Deleted
    public DateTime LastLoginAt { get; set; }
}
