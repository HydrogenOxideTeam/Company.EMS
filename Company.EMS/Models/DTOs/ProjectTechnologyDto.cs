using Company.EMS.Models.Entities.Enums;

namespace Company.EMS.Models.DTOs;

public record ProjectTechnologyDto()
{
    public int Id { get; set; }
    public int ProjectId { get; set; } 
    public int Technology { get; set; }
}