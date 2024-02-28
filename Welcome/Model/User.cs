using System;
using Welcome.Others;

public class User
{

    public string Name { get; set; }
    public string HashedPassword { get; private set; }
    public string Password {
        get { return HashedPassword; }
        set => HashedPassword = BCrypt.Net.BCrypt.HashPassword(value);
    }
    public string Email { get; set; }
    public string FacultyNumber{ get; set; }
    public UserRolesEnum Role { get; set; }

    public User(string name, string pass, string email, string facNum, UserRolesEnum role)
    {
        Name = name;
        Password = pass;
        Email = email;
        FacultyNumber = facNum;
        Role = role;
    }

    public bool VerifyPassword(string password)
    {
        return BCrypt.Net.BCrypt.Verify(password, HashedPassword);
    }

}
