using Dorixona.Application.Abstractions.Messages;
using Dorixona.Domain.Abstractions;
using Dorixona.Domain.Models.UserModel.Proporties;
using Dorixona.Domain.Models.UserModel.UserRepository;
using Dorixona.Domain.Models.UserModel;
using Dorixona.Application.Pattern;

namespace Dorixona.Application.Homes.Command.ConfirmCode;

internal sealed class ConfirmCodeCommandHandle : ICommandHandle<ConfirmCodeCommand, Guid>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;
    public ConfirmCodeCommandHandle(IUserRepository userRepository, IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
        _userRepository = userRepository;
    }
    public async Task<Result<Guid>> Handle(ConfirmCodeCommand request, CancellationToken cancellationToken)
    {
        if(request.code == Singleton.Instance.Code)
        {
            var userModel = new UserDTO
            {
                FullName = new FullName(Singleton.Instance.FullName),
                PhoneNumber = new PhoneNumber(Singleton.Instance.PhoneNumber),
                Username = new Username(Singleton.Instance.UserName),
                Password = new Password(Singleton.Instance.Password),
                UserType = new UserType("User")
            };

            Guid guid = Guid.NewGuid();

            var user = User.CreateUser(guid, userModel);

            _userRepository.Add(user);

            await _unitOfWork.SaveChangesAsync();

            return guid;
        }

        return Result.Failure<Guid>(Error.CodeError);
    }
}
