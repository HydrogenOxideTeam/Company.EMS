using Company.EMS.Data;
using Company.EMS.Models.Entities;
using Company.EMS.Repositories.Abstractions;
using Company.EMS.Repositories.Generic;
using Microsoft.EntityFrameworkCore;

namespace Company.EMS.Repositories;

public class AccountRepository: Repository<Account>, IAccountRepository
{
    public AccountRepository(ApplicationDbContext context) : base(context) { }
}