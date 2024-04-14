using Company.EMS.Data;
using Company.EMS.Models.Entities;
using Microsoft.AspNetCore.Identity;

namespace Company.EMS.Repositories.Generic;

public class UnitOfWork(ApplicationDbContext context): IUnitOfWork
{
    public IRepository<Account> Accounts { get; } = new Repository<Account>(context);
    public IRepository<Assignment> Assignments { get; } = new Repository<Assignment>(context);
    public IRepository<Developer> Developers { get; } = new Repository<Developer>(context);
    public IRepository<Engagement> Engagements { get; } = new Repository<Engagement>(context);
    public IRepository<ProjectManager> ProjectManagers { get; } = new Repository<ProjectManager>(context);
    public IRepository<Project> Projects { get; } = new Repository<Project>(context);
    public IRepository<SalesManager> SalesManagers { get; } = new Repository<SalesManager>(context);
    public IRepository<IdentityUser> Users { get; } = new Repository<IdentityUser>(context);
    
    public async Task<int> CompleteAsync()
    {
        return await context.SaveChangesAsync();
    }
    public void Dispose()
    {
        context.Dispose();
    }
}