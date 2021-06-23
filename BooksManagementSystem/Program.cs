using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksManagementSystem
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            login Login = new login();
            Application.Run(Login);
            if(Login.DialogResult == DialogResult.OK)
            {
                Login.Dispose();
                Application.Run(new BorrowersForm());
            }
            if (Login.DialogResult == DialogResult.Yes)
            {
                Login.Dispose();
                Application.Run(new AdminMainForm());
            }
        }
    }
}
