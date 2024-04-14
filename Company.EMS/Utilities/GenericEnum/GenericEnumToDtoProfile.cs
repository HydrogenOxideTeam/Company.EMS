using AutoMapper;

namespace Company.EMS.Models.Configuration;

public class GenericEnumToDtoProfile: Profile
{
    public GenericEnumToDtoProfile()
    {
        CreateMap(typeof(Enum), typeof(EnumDto))
            .ConvertUsing(typeof(GenericEnumToDtoConverter));
    }
}