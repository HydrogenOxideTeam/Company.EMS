namespace Company.EMS.Models.DTOs;

public record ProjectStatusDto()
{
    public int Id { get; init; }
    public string? Name { get; init; }
}