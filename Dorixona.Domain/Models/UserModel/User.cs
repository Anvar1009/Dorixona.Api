using Dorixona.Domain.Abstractions;
using Dorixona.Domain.Models.UserModel.Proporties;

namespace Dorixona.Domain.Models.UserModel;

public sealed class User : Entity
{
    private User(Guid id, UserDTO userDTO) : base(id)
    {
        FullName = userDTO.FullName;
        PhoneNumber = userDTO.PhoneNumber;
        Username = userDTO.Username;
        Password = userDTO.Password;
        UserType = userDTO.UserType;
    }
    protected User(){ }
    public FullName FullName { get; set; }
    public PhoneNumber PhoneNumber { get; set; }
    public Username Username { get; set; }
    public Password Password { get; set; }
    public UserType UserType { get; set; }
    public static User CreateUser(Guid Id, UserDTO userDTO)
    {
        return new User(Id, userDTO);
    }
}
