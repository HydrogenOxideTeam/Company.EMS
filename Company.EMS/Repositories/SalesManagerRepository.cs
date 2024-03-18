using Company.EMS.Data;
using Company.EMS.Models.Entities;
using Company.EMS.Repositories.Abstractions;
using Company.EMS.Repositories.Generic;

namespace Company.EMS.Repositories;

public class SalesManagerRepository: Repository<SalesManager>, ISalesManagerRepository
{
    public SalesManagerRepository(ApplicationDbContext context) : base(context) { }
}