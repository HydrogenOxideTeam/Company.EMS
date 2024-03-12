namespace Company.EMS.CQS.Commands.CreateExample;

public record CreateExampleRequest
{
    public string Name { get; init; }
}