using Dorixona.Domain.Abstractions;

namespace Dorixona.Domain.Models.UserModel;

public static class UserError
{
    public static Error NotFound = new(
        "User.NotFound",
        "The User with the specified identifier was not found");

    public static Error UserNull = new(
        "User.Null",
        "It can't create for User null");
    public static Error ExistUsername = new(
        "UserName.NotExist",
        "Username already exist"
        );
}
