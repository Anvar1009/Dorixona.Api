using Dorixona.Application.Abstractions.Messages;
using Dorixona.Application.Pattern;
using Dorixona.Domain.Abstractions;
using Dorixona.Domain.Models.UserModel;
using Dorixona.Domain.Models.UserModel.UserRepository;

namespace Dorixona.Application.Homes.Command.RegisterUser;

internal sealed class CreateCommandHandle : ICommandHandle<CreateUserCommand, int>
{
    public async Task<Result<int>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        if (request == null)
            return Result.Failure<int>(UserError.UserNull);

        int code = new Random().Next(1000, 10000);

        Singleton.Instance.FullName = request.CreateUserDTO.FullName;
        Singleton.Instance.UserName = request.CreateUserDTO.Username;
        Singleton.Instance.Password = request.CreateUserDTO.Password;
        Singleton.Instance.PhoneNumber = request.CreateUserDTO.PhoneNumber;
        Singleton.Instance.Code = code;

        return code;
    }
}
