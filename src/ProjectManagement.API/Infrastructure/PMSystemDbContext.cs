using System.Reflection;

using Microsoft.EntityFrameworkCore;

using ProjectManagement.API.Infrastructure.Configuration;
using ProjectManagement.API.Models;

namespace ProjectManagement.API.Infrastructure;

public class PMSystemDbContext(DbContextOptions<PMSystemDbContext> options) : DbContext(options)
{
    public DbSet<Workspace> Workspaces { get; set; }
    public DbSet<Member> Members { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
