using UserLoginApp.Forms;
using UserLoginApp.Services;

namespace UserLoginApp
{
    internal static class Program
    {
        public static UserService userService = new UserService();
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new RegistrationForm());
        }
    }
}