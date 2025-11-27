using System;
using System.Windows.Forms;
using CarServiceApp.Data;
using Microsoft.EntityFrameworkCore;

namespace CarServiceApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var ctx = new AutoDbContext())
            {
                ctx.Database.Migrate(); // Автоматически применяет миграции
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
