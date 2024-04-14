namespace Company.EMS.Helpers;

/// <summary>
/// 
/// </summary>
public static class ExampleHelper
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="birthDate"></param>
    /// <returns></returns>
    public static int CalculateAge(DateTime birthDate)
    {
        var today = DateTime.Today;
        var age = today.Year - birthDate.Year;
        
        if (birthDate.Date > today.AddYears(-age)) age--;

        return age;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="date"></param>
    /// <returns></returns>
    public static string FormatAsFriendlyDate(DateTime date)
    {
        return date.ToString("MMM dd, yyyy");
    }
}