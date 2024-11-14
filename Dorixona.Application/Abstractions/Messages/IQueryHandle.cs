using Dorixona.Domain.Abstractions;
using MediatR;

namespace Dorixona.Application.Abstractions.Messages;

public interface IQueryHandle<TRequest, TResponse> : IRequestHandler<TRequest, Result<TResponse>>
    where TRequest : IQuery<TResponse>
{
}
