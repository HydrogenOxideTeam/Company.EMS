using Company.EMS.Data;
using Company.EMS.Repositories.Abstractions;
using Company.EMS.Repositories.Generic;
using Microsoft.AspNetCore.Identity;

namespace Company.EMS.Repositories;

public class UserRepository: Repository<IdentityUser>, IUserRepository
{
    public UserRepository(ApplicationDbContext context) : base(context) { }
}