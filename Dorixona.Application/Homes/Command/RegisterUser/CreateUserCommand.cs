using Dorixona.Application.Abstractions.Messages;
using Dorixona.Domain.Models.UserModel;

namespace Dorixona.Application.Homes.Command.RegisterUser;

public record CreateUserCommand(CreateUserDTO CreateUserDTO) : ICommand<int>;
