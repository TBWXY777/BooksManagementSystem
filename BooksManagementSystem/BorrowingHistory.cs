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

namespace BooksManagementSystem
{
    public partial class BorrowingHistory : Form
    {
        private string readerId;
        public BorrowingHistory()
        {
            InitializeComponent();
        }
        public void getid(string id)
        {
            readerId = id;
        }

        private void BorrowingHistory_Load(object sender, EventArgs e)
        {
            string sql = "SELECT book.book_name as 书名,reader_book.borrow_date as 借出时间,reader_book.theory_return_date as 预期归还时间,reader_book.return_date as 实际归还时间 FROM reader_book,book WHERE reader_book.r_id={0} AND book.b_id=reader_book.b_id";
            sql = String.Format(sql, readerId);
            var dt = MysqlUtils.QueryToDataTable(sql);
            dataGridView.DataSource = dt;
        }
    }
}
