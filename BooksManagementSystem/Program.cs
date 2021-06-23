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
            Login login = new Login();
            Application.Run(login);
            if(login.DialogResult == DialogResult.OK)
            {
                login.Dispose();
                Application.Run(new BorrowersForm(login.id));
            }
            if (login.DialogResult == DialogResult.Yes)
            {
                login.Dispose();
                Application.Run(new AdminMainForm());
            }
        }
    }
}
