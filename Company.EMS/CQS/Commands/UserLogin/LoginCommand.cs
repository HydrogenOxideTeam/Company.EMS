using Company.EMS.CQS.Configurations.Commands;

namespace Company.EMS.CQS.Commands.UserLogin;

public class LoginCommand: CommandBase<string>
{
    public string Email { get; set; }
    public string Password { get; set; }

    public LoginCommand(string email, string password)
    {
        Email = email;
        Password = password;
    }
}