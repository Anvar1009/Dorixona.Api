using Dorixona.Domain.Models.UserModel.Proporties;

namespace Dorixona.Domain.Models.UserModel;

public class UserDTO
{
    public FullName FullName { get; set; }
    public PhoneNumber PhoneNumber { get; set; }
    public Username Username { get; set; }
    public Password Password { get; set; }
    public UserType UserType { get; set; }
}
