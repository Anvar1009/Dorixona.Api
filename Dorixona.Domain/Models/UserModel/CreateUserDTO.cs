﻿namespace Dorixona.Domain.Models.UserModel;

public class CreateUserDTO
{
    public string FullName { get; set; }
    public string PhoneNumber { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}