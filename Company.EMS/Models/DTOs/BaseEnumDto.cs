namespace Company.EMS.Models.DTOs;

public abstract record BaseEnumDto()
{
    public int Id { get; init; }
    public string? Name { get; init; }
}