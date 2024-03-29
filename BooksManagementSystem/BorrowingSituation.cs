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

namespace BooksManagementSystem
{
    public partial class BorrowingSituation : Form
    {
        private string readerId;
        public BorrowingSituation()
        {
            InitializeComponent();
        }
        public void  getid(string id)
        {
            readerId = id;
        }

        private void BorrowingSituation_Load(object sender, EventArgs e)
        {
            string sql = "SELECT book.book_name as 书名,reader_book.borrow_date as 借出时间,reader_book.theory_return_date as 归还时间 FROM reader_book,book WHERE reader_book.r_id={0} AND book.b_id=reader_book.b_id AND reader_book.return_date is NULL";
            sql = String.Format(sql, readerId);
            var dt = MysqlUtils.QueryToDataTable(sql);
            dataGridView.DataSource = dt;
        }
    }
}
