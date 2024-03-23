using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Company.EMS.CQS.Commands.UserLogin;
using Company.EMS.CQS.Commands.UserRegister;
using Company.EMS.Services.Abstractions;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace Company.EMS.Services;

public class UserService(UserManager<IdentityUser> userManager, IConfiguration configuration): IUserService
{
    private readonly UserManager<IdentityUser> _userManager = userManager;
    private readonly IConfiguration _configuration = configuration;

    public async Task<string> RegisterUserAsync(RegisterCommand command)
    {
        var user = new IdentityUser { UserName = command.UserName, Email = command.Email };
        var result = await _userManager.CreateAsync(user, command.Password);
        if (!result.Succeeded)
        {
            throw new Exception(string.Join("\n", result.Errors.Select(e => e.Description)));
        }
        await userManager.AddToRoleAsync(user, "CommonUser");
        return GenerateJwtToken(user);
    }

    public async Task<string> LoginUserAsync(LoginCommand command)
    {
        var user = await _userManager.FindByEmailAsync(command.Email);
        if (user == null)
        {
            throw new InvalidDataException("User was not found");
        }

        if (!await _userManager.CheckPasswordAsync(user, command.Password))
        {
            throw new InvalidDataException("Email or password are incorrect");
        }
        return GenerateJwtToken(user);
    }

    private string GenerateJwtToken(IdentityUser user)
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_configuration["Jwt:Key"]);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                new Claim(ClaimTypes.Email, user.Email)
            }),
            Expires = DateTime.UtcNow.AddDays(7),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}