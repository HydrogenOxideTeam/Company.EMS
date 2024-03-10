using Company.EMS.Models.DTOs;

namespace Company.EMS.Services.Abstractions;

public interface IExampleService
{
    Task<ExampleDto> CreateExampleAsync(string name);
    Task<ExampleDto> GetExampleByIdAsync(int id);
}