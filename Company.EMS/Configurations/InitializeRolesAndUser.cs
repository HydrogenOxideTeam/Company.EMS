using Microsoft.AspNetCore.Identity;

namespace Company.EMS.Configurations;

public static class InitializeRolesAndUser
{
    public static async Task CreateRolesAsync(IServiceProvider serviceProvider)
    {
        var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
        string[] roleNames = { "Admin", "ProjectManager", "SalesManager", "Developer", "CommonUser" };

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
    }
}