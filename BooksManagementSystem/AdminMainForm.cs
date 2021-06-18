using ConnectSql;
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
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void 书籍维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BookMainForm().Show();
        }

        private void 添加书籍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var bookForm =new BookMainForm();
            
        }

        private void 读者表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "select * from reader";
            var dt = MysqlUtils.QueryToDataTable(sql);
            var dbForm = new DataBaseForm();
            dbForm.dbGridView.DataSource = dt;
            dbForm.Show();
        }

        private void 书籍表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "select * from book";
            var dt = MysqlUtils.QueryToDataTable(sql);
            var dbForm = new DataBaseForm();
            dbForm.dbGridView.DataSource = dt;
            dbForm.Show();
            ((DataGridViewImageColumn)dbForm.dbGridView.Columns["pic"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void 读者书籍表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "select * from reader_book";
            var dt = MysqlUtils.QueryToDataTable(sql);
            var dbForm = new DataBaseForm();
            dbForm.dbGridView.DataSource = dt;
            dbForm.Show();
        }

        private void 书籍书架表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "select * from book_shelf";
            var dt = MysqlUtils.QueryToDataTable(sql);
            var dbForm = new DataBaseForm();
            dbForm.dbGridView.DataSource = dt;
            dbForm.Show();
        }

        private void 管理员表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "select * from admin";
            var dt = MysqlUtils.QueryToDataTable(sql);
            var dbForm = new DataBaseForm();
            dbForm.dbGridView.DataSource = dt;
            dbForm.Show();
        }
    }
}
