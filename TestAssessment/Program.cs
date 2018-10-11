using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAssessment
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Banner banner = new Banner();
            DateTime end = DateTime.Now + TimeSpan.FromSeconds(3);
            banner.Show();
            while (end > DateTime.Now)
            {
                Application.DoEvents();
            }
            banner.Close();
            banner.Dispose();
            Application.Run(new Authorization());
        }
    }
}
