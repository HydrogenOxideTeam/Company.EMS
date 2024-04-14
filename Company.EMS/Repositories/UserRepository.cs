using Company.EMS.Data;
using Company.EMS.Repositories.Abstractions;
using Company.EMS.Repositories.Generic;
using Microsoft.AspNetCore.Identity;

namespace Company.EMS.Repositories;

public class UserRepository(ApplicationDbContext context): Repository<IdentityUser>(context), IUserRepository
{
}