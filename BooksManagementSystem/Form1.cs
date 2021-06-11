using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsWithSql;

namespace BooksManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 书籍维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BookMainForm().Show();
        }
    }
}
