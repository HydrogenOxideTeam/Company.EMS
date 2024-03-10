namespace Company.EMS.Models.Entities;

public class UserProfile
{
    public int UserId { get; set; } 
    //public User User {get;set;}
    public string? LastName { get; set; } 
    public string? PhoneNumber { get; set; } 
    public string? AvatarUrl { get; set; } 
    public DateOnly Date { get; set; }

    public UserProfile(int userId, string? lastName, string? phoneNumber, string? avatarUrl, DateOnly date)
    {
        UserId = userId;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        AvatarUrl = avatarUrl;
        Date = date;
    }
}