using Dorixona.Application.Abstractions.Messages;

namespace Dorixona.Application.Homes.Command.ConfirmCode;

public record ConfirmCodeCommand(int code) : ICommand<Guid>;
