using System;

namespace UserLoginApp.Models;

public class User
{
    public User(
        string fname,
        string lname,
        string username,
        string email,
        string phone,
        string password)
    {
        Id = Guid.NewGuid();

        FName = fname;
        LName = lname;
        UserName = username;
        Email = email;
        Phone = phone;
        Password = password;
    }

    public Guid Id { get; private set; }

    public string FName { get; private set; }

    public string LName { get; private set; }

    public string UserName { get; private set; }

    public string Email { get; private set; }

    public string Phone { get; private set; }

    public string Password { get; private set; }
}