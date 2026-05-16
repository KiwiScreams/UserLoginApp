using UserLoginApp.Models;

namespace UserLoginApp.Services;

public class UserService
{
    private FileService fileService = new FileService();

    public bool RegisterUser(
        string fname,
        string lname,
        string userName,
        string email,
        string phone,
        string password)
    {
        if (
            fname.Trim() == "" ||
            lname.Trim() == "" ||
            userName.Trim() == "" ||
            email.Trim() == "" ||
            phone.Trim() == "" ||
            password.Trim() == ""
           )
        {
            return false;
        }

        if (!email.Contains("@") || !email.Contains("."))
        {
            return false;
        }

        if (phone.Length < 9)
        {
            return false;
        }

        List<User> users = fileService.ReadUsers();

        foreach (User user in users)
        {
            if (
                user.UserName == userName ||
                user.Email == email ||
                user.Phone == phone
               )
            {
                return false;
            }
        }

        User newUser = new User(
            fname,
            lname,
            userName,
            email,
            phone,
            password
        );

        users.Add(newUser);

        fileService.WriteUsers(users);

        return true;
    }

    public User AuthenticateUser(string userName, string password)
    {
        List<User> users = fileService.ReadUsers();

        foreach (User user in users)
        {
            if (
                user.UserName == userName &&
                user.Password == password
               )
            {
                return user;
            }
        }

        return null;
    }

    public User GetUserByUsername(string userName)
    {
        List<User> users = fileService.ReadUsers();

        foreach (User user in users)
        {
            if (user.UserName == userName)
            {
                return user;
            }
        }

        return null;
    }
}