using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using WinFormsApp2.Model;

namespace WinFormsApp2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

        
            using (var dbContext = new RestaurantDbContext())
            {
                var tableForm = new Table(dbContext);

                Application.Run(tableForm);
            }
        }
    }
}