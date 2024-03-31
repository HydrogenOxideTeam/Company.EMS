using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Company.EMS.Models.DTOs;
using Company.EMS.Models.DTOs.Validators;
using Company.EMS.Services.Abstractions;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using ValidationException = System.ComponentModel.DataAnnotations.ValidationException;

namespace Company.EMS.Services;

public class UserService(UserManager<IdentityUser> userManager, IConfiguration configuration): IUserService
{
    private readonly UserManager<IdentityUser> _userManager = userManager;
    private readonly IConfiguration _configuration = configuration;

    public async Task<string> RegisterUserAsync(RegisterDto request)
    {
        var user = new IdentityUser { UserName = request.UserName, Email = request.Email };
        var result = await _userManager.CreateAsync(user, request.Password);
        if (!result.Succeeded)
        {
            throw new Exception(string.Join("\n", result.Errors.Select(e => e.Description)));
        }
        await userManager.AddToRoleAsync(user, "CommonUser");
        return await GenerateJwtToken(user);
    }

    public async Task<string> LoginUserAsync(LoginDto request)
    {
        var user = await _userManager.FindByEmailAsync(request.Email);
        if (user == null)
        {
            throw new InvalidDataException("User was not found");
        }

        if (!await _userManager.CheckPasswordAsync(user, request.Password))
        {
            throw new InvalidDataException("Email or password are incorrect");
        }
        return await GenerateJwtToken(user);
    }

    private async Task<string> GenerateJwtToken(IdentityUser user)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]);
    
        // Fetch roles for the user
        var roles = await _userManager.GetRolesAsync(user);
    
        var claims = new List<Claim>
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id),
            new Claim(ClaimTypes.Email, user.Email)
        };

        foreach (var role in roles)
        {
            claims.Add(new Claim(ClaimTypes.Role, role));
        }
    
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.UtcNow.AddDays(7),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}