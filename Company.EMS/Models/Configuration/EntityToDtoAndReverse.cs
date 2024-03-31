using AutoMapper;
using Company.EMS.Models.DTOs;
using Company.EMS.Models.Entities;

namespace Company.EMS.Models.Configuration;

public class EntityToDtoAndReverse: Profile
{
    public EntityToDtoAndReverse()
    {
        CreateMap<Account, AccountDto>().ReverseMap();
        CreateMap<Assignment, AssigmentDto>().ReverseMap();
        CreateMap<Developer, DeveloperDto>().ReverseMap();
        CreateMap<DeveloperProject, DeveloperProjectDto>().ReverseMap();
        CreateMap<DeveloperReportAssignment, DeveloperReportAssigmentDto>().ReverseMap();
        CreateMap<DeveloperReport, DeveloperReportDto>().ReverseMap();
        CreateMap<DeveloperTechnology, DeveloperTechnologyDto>().ReverseMap();
        CreateMap<Engagement, EngagementDto>().ReverseMap();
        CreateMap<Project, ProjectDto>().ReverseMap();
        CreateMap<ProjectManager, ProjectManagerDto>().ReverseMap();
        CreateMap<ProjectTechnology, ProjectTechnologyDto>().ReverseMap();
        CreateMap<ReportFeedback, ReportFeedbackDto>().ReverseMap();
        CreateMap<SalesManager, SalesManagerDto>().ReverseMap();
        CreateMap<SalesManagerReport, SalesManagerReportDto>().ReverseMap();
        CreateMap<SalesManagerReportEngagement, SalesManagerReportEngagementDto>().ReverseMap();
        CreateMap<UserProfile, UserProfileDto>().ReverseMap();
    }
}