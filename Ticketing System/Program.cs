using Ticketing_System.Data;
using Ticketing_System.Forms;

namespace Ticketing_System
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            DataAccess.InitializeDatabase();
            using(LoginForm login = new LoginForm())
            {
                if(login.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new MainMenu());
                }
            }
            
        }
    }
}