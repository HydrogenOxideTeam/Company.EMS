using Microsoft.AspNetCore.Identity;

namespace Company.EMS.Configurations;

/// <summary>
/// 
/// </summary>
public static class InitializeRolesAndUser
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="serviceProvider"></param>
    public static async Task CreateRolesAsync(IServiceProvider serviceProvider)
    {
        var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
        string[] roleNames = {"Admin", "ProjectManager", "SalesManager", "Developer", "CommonUser"};

        foreach (var roleName in roleNames)
        {
            var roleExist = await roleManager.RoleExistsAsync(roleName);
            if (!roleExist)
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }
        }

        var powerUsers = new List<IdentityUser>()
        {
            new IdentityUser()
            {
                UserName = "AndriiPerevoshchenko",
                Email = "a.perevoshchenko@gmail.com",
            },
            new IdentityUser()
            {
                UserName = "OlenaPanychok",
                Email = "olenkapanychok@gmail.com",
            }
        };
        var otherUsers = new List<IdentityUser>()
        {
            new IdentityUser()
            {
                UserName = "DeveloperTest",
                Email = "developer@test.com"
            },
            new IdentityUser()
            {
                UserName = "SalesManagerTest",
                Email = "salesmanager@test.com"
            },
            new IdentityUser()
            {
                UserName = "ProjectManagerTest",
                Email = "projectmanager@test.com"
            },
            new IdentityUser()
            {
                UserName = "UserTest",
                Email = "commonuser@test.com"
            }
        };

        var userPassword = "Abc&123!";

        foreach (var powerUser in powerUsers)
        {
            var user = await userManager.FindByEmailAsync(powerUser.Email!);

            if (user != null) continue;
            
            var createPowerUser = await userManager.CreateAsync(powerUser, userPassword);
            if (createPowerUser.Succeeded)
            {
                await userManager.AddToRoleAsync(powerUser, "Admin");
            }
        }

        var userDeveloper = await userManager.FindByEmailAsync(otherUsers[0].Email!);
        if (userDeveloper == null)
        {
            var createUser = await userManager.CreateAsync(otherUsers[0], userPassword);
            if (createUser.Succeeded)
            {
                await userManager.AddToRoleAsync(otherUsers[0], "Developer");
            }
        }
        
        var userSalesManager = await userManager.FindByEmailAsync(otherUsers[1].Email!);
        if (userSalesManager == null)
        {
            var createUser = await userManager.CreateAsync(otherUsers[1], userPassword);
            if (createUser.Succeeded)
            {
                await userManager.AddToRoleAsync(otherUsers[1], "SalesManager");
            }
        }
        
        var userProjectManager = await userManager.FindByEmailAsync(otherUsers[2].Email!);
        if (userProjectManager == null)
        {
            var createUser = await userManager.CreateAsync(otherUsers[2], userPassword);
            if (createUser.Succeeded)
            {
                await userManager.AddToRoleAsync(otherUsers[2], "ProjectManager");
            }
        }
        
        var userCommon = await userManager.FindByEmailAsync(otherUsers[3].Email!);
        if (userCommon == null)
        {
            var createUser = await userManager.CreateAsync(otherUsers[3], userPassword);
            if (createUser.Succeeded)
            {
                await userManager.AddToRoleAsync(otherUsers[3], "CommonUser");
            }
        }
    }
    
    //     [Authorize(AuthenticationSchemes = "Bearer")]
//     [HttpGet]
//     [Route("api/Tokens")]
//     public IActionResult TestAuthorization()
//     {
//         return Ok("You're Authorized");
//     }
}