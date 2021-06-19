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
    public partial class BorrowingSituation : Form
    {
        public BorrowingSituation()
        {
            InitializeComponent();
        }

        private void BorrowingSituation_Load(object sender, EventArgs e)
        {
            string id = "100001";
            string sql = "SELECT book.book_name as 书名,reader_book.borrow_date as 借出时间,reader_book.return_date as 归还时间 FROM reader_book,book WHERE book.b_id=reader_book.b_id";
            sql = String.Format(sql, id, id);
            var dt = MysqlUtils.QueryToDataTable(sql);
            dataGridView.DataSource = dt;
           

        }
    }
}
