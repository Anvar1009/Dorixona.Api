using Dorixona.Domain.Abstractions;
using MediatR;


namespace Dorixona.Application.Abstractions.Messages;

public interface ICommandHandle<TCommand> : IRequestHandler<TCommand, Result>
    where TCommand : ICommand
{

}

public interface ICommandHandle<TCommand, TResponce> : IRequestHandler<TCommand, Result<TResponce>>
    where TCommand : ICommand<TResponce>
{

}
