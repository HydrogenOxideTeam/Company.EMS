using Company.EMS.Data;
using Company.EMS.Models.Entities;
using Company.EMS.Repositories.Abstractions;
using Company.EMS.Repositories.Generic;

namespace Company.EMS.Repositories;

public class EngagementRepository: Repository<Engagement>, IEngagementRepository
{
    public EngagementRepository(ApplicationDbContext context) : base(context) { }
}