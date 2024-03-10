using MediatR;
namespace Company.EMS.CQS.Configurations.Commands;

public interface ICommand: IRequest
{
    Guid Id { get; }
}

public interface ICommand<out TResult> : IRequest<TResult>
{
    Guid Id { get; }
}