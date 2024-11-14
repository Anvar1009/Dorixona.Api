using Dorixona.Domain.Abstractions;
using MediatR;

namespace Dorixona.Application.Abstractions.Messages;

public interface ICommand : IRequest<Result>, IBaseCommand
{
}

public interface ICommand<T> : IRequest<Result<T>>, IBaseCommand
{
}

public interface IBaseCommand
{
}
