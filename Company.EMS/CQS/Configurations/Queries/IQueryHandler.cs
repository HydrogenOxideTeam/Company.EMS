using MediatR;

namespace Company.EMS.CQS.Configurations.Queries;

public interface IQueryHandler<in TQuery, TResult> :
    IRequestHandler<TQuery, TResult> where TQuery : IQuery<TResult>
{
}