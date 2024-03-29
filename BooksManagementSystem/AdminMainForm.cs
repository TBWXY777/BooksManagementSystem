﻿using ConnectSql;
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

        private void button1_Click(object sender, EventArgs e)
        {
            BorrowersForm a = new BorrowersForm();
            a.Show();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Borrowbook X = new Borrowbook();
            X.Show();
            this.Hide();
        }

        private void returnbut2_Click(object sender, EventArgs e)
        {
            returnbook X = new returnbook();
            X.Show();
            this.Hide();
        }

        private void 添加读者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBorrowerForm a = new AddBorrowerForm();
            a.Show();
        }

        private void 删除读者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteBorrowerForm d = new DeleteBorrowerForm();
            d.Show();
        }

        private void 查询读者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBorrowerForm s = new SearchBorrowerForm();
            s.Show();
        }

        private void 更新读者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifyBorrowerForm m = new ModifyBorrowerForm();
            m.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BorrowersForm a = new BorrowersForm();
            a.Show();
        }
    }
}
