using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace curs1
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string currentDirectoryPath = Path.GetDirectoryName(Application.ExecutablePath);
            //if (!File.Exists($"{currentDirectoryPath}\\dataBase.db"))
            //{
                //new Database("Data Source=dbcurs.db;Version=3;").InitializeDatabase();
            //}
            Application.Run(new FormAuth());
            //string.currentDirectocryPath = Path.GetDirectoryName(Application.ExecutablePath);
        }
    }
}
