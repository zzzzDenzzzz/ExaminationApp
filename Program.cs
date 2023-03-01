using Microsoft.EntityFrameworkCore;

namespace ExaminationApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using var context = new BookStoreContext();
            context.Database.Migrate();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}