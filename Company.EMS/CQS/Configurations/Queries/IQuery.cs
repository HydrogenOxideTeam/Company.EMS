using MediatR;

namespace Company.EMS.CQS.Configurations.Queries;

public interface IQuery<out TResult> : IRequest<TResult>
{ 
}