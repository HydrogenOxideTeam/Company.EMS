namespace Company.EMS.Helpers;

public static class ExampleHelper
{
    public static int CalculateAge(DateTime birthDate)
    {
        var today = DateTime.Today;
        var age = today.Year - birthDate.Year;
        
        if (birthDate.Date > today.AddYears(-age)) age--;

        return age;
    }

    public static string FormatAsFriendlyDate(DateTime date)
    {
        return date.ToString("MMM dd, yyyy");
    }
}