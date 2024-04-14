using Company.EMS.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Company.EMS.Data;

/// <summary>
/// 
/// </summary>
public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<IdentityUser>(options)
{
    public DbSet<Account> Accounts { get; init; }
    public DbSet<Assignment> Assignments { get; init; }
    public DbSet<Developer> Developers { get; init; }
    public DbSet<DeveloperProject> DeveloperProjects { get; init; }
    public DbSet<DeveloperReport> DeveloperReports { get; init; }
    public DbSet<DeveloperReportAssignment> DeveloperReportAssignments { get; init; }
    public DbSet<DeveloperTechnology> DeveloperTechnologies { get; init; }
    public DbSet<Engagement> Engagements { get; init; }
    public DbSet<Project> Projects { get; init; }
    public DbSet<ProjectManager> ProjectManagers { get; init; }
    public DbSet<ProjectTechnology> ProjectTechnologies { get; init; }
    public DbSet<ReportFeedback> ReportFeedbacks { get; init; }
    public DbSet<SalesManager> SalesManagers { get; init; }
    public DbSet<SalesManagerReport> SalesManagerReports { get; init; }
    public DbSet<SalesManagerReportEngagement> SalesManagerReportEngagements { get; init; }
    public DbSet<UserProfile> UserProfiles { get; init; }
}