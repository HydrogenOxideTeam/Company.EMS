using Company.EMS.CQS.Configurations.Queries;
using Company.EMS.Models.DTOs;

namespace Company.EMS.CQS.Queries.GetExample;

public class GetExampleQuery: IQuery<ExampleDto>
{
    public int Id { get; set; }

    public GetExampleQuery(GetExampleRequest request)
    {
        Id = request.Id;
    }
}