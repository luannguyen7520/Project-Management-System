using Asp.Versioning;

using Microsoft.EntityFrameworkCore;

using ProjectManagement.API.Application.Interfaces;
using ProjectManagement.API.Application.Services;
using ProjectManagement.API.Infrastructure;
using ProjectManagement.API.Infrastructure.Interfaces;
using ProjectManagement.API.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddApiVersioning(options =>
{
    options.DefaultApiVersion = new ApiVersion(1, 0);
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.ReportApiVersions = true;
    options.ApiVersionReader = new UrlSegmentApiVersionReader();
})
.AddMvc()
.AddApiExplorer(options =>
{
   options.GroupNameFormat = "'v'VVV";
   options.SubstituteApiVersionInUrl = true; 
});
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<PMSystemDbContext>(options =>
{
   options.UseNpgsql(builder.Configuration.GetConnectionString("PMSystemDatabase")); 
});

builder.Services.AddScoped<IWorkspaceRepository, WorkspaceRepository>();
builder.Services.AddScoped<IWorkspaceService, WorkspaceService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
