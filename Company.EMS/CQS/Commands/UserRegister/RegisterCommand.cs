using Company.EMS.CQS.Configurations.Commands;

namespace Company.EMS.CQS.Commands.UserRegister;

public class RegisterCommand: CommandBase<string>
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }

    public RegisterCommand(string userName, string email, string password, string confirmPassword)
    {
        UserName = userName;
        Email = email;
        Password = password;
        ConfirmPassword = confirmPassword;
    }
}
