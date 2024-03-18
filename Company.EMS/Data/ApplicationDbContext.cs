using Company.EMS.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Company.EMS.Data;

public class ApplicationDbContext : IdentityDbContext<IdentityUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }
    
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Assignment> Assignments { get; set; }
    public DbSet<Developer> Developers { get; set; }
    public DbSet<DeveloperProject> DeveloperProjects { get; set; }
    public DbSet<DeveloperReport> DeveloperReports { get; set; }
    public DbSet<DeveloperReportAssignment> DeveloperReportAssignments { get; set; }
    public DbSet<DeveloperTechnology> DeveloperTechnologies { get; set; }
    public DbSet<Engagement> Engagements { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<ProjectManager> ProjectManagers { get; set; }
    public DbSet<ProjectTechnology> ProjectTechnologies { get; set; }
    public DbSet<ReportFeedback> ReportFeedbacks { get; set; }
    public DbSet<SalesManager> SalesManagers { get; set; }
    public DbSet<SalesManagerReport> SalesManagerReports { get; set; }
    public DbSet<SalesManagerReportEngagement> SalesManagerReportEngagements { get; set; }
    public DbSet<UserProfile> UserProfiles { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}