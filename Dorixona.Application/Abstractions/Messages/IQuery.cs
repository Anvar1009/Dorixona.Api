using Dorixona.Domain.Abstractions;
using MediatR;

namespace Dorixona.Application.Abstractions.Messages;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}
