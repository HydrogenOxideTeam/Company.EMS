using Company.EMS.Repositories.Generic;
using Microsoft.AspNetCore.Identity;

namespace Company.EMS.Repositories.Abstractions;

public interface IUserRepository: IRepository<IdentityUser>
{
    
}