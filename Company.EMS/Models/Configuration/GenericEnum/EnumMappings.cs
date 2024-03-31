namespace Company.EMS.Models.Configuration;

public static class EnumMappings
{
    public static EnumDto ToDto<TEnum>(TEnum enumValue) where TEnum : Enum
    {
        return new EnumDto
        {
            Id = Convert.ToInt32(enumValue),
            Name = enumValue.ToString()
        };
    }
}