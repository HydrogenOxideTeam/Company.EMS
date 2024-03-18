using Company.EMS.Data;
using Company.EMS.Models.Entities;
using Company.EMS.Repositories.Abstractions;
using Company.EMS.Repositories.Generic;

namespace Company.EMS.Repositories;

public class ProjectManagerRepository: Repository<ProjectManager>, IProjectManagerRepository
{
    public ProjectManagerRepository(ApplicationDbContext context) : base(context) { }
}