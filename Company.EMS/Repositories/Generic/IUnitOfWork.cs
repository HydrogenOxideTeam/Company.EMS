using Company.EMS.Models.Entities;
using Microsoft.AspNetCore.Identity;

namespace Company.EMS.Repositories.Generic;

public interface IUnitOfWork: IDisposable
{
    IRepository<Account> Accounts { get; }
    IRepository<Assignment> Assignments { get; }
    IRepository<Developer> Developers { get; }
    IRepository<Engagement> Engagements { get; }
    IRepository<ProjectManager> ProjectManagers { get; }
    IRepository<Project> Projects { get; }
    IRepository<SalesManager> SalesManagers { get; }
    IRepository<IdentityUser> Users { get; }
    IRepository<UserProfile> UserProfiles { get; } 

    Task<int> CompleteAsync();
}