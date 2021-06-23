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
    public partial class BorrowersForm : Form
    {
        private string readerId;

        public BorrowersForm()
        {
            InitializeComponent();
        }

        public BorrowersForm(string id)
        {
            InitializeComponent();
            readerId = id;
        }

        private void BorrowersForm_Load(object sender, EventArgs e)
        {
            //根据借阅者ID显示信息，先初始化ID方便测试
            string sql = "SELECT * FROM reader WHERE r_id={0}";
            sql = String.Format(sql, readerId);
            DataRow row = MysqlUtils.QueryOne(sql);
            NameTextBox.Text= row["r_name"].ToString();
            MajorTextBox.Text = row["major"].ToString();
            DeptTextBox.Text = row["dep"].ToString();
            textBox1.Text = row["borrowed"].ToString();
            textBox2.Text = row["allow_borrow"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BorrowingSituation a = new BorrowingSituation();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
