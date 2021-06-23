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
using MySql.Data.MySqlClient;
using WindowsFormsWithSql;
using System.Data.SqlClient;

namespace BooksManagementSystem
{
    public partial class Borrowbook : Form
    {
        public Borrowbook()
        {
            InitializeComponent();
        }
        public void Intday()
        {
            daycom.Items.Add("1");
            daycom.Items.Add("3");
            daycom.Items.Add("7");
        }
        private void borrowbut_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection con;
            string xom;
            xom = MysqlUtils.connectStr;
            con = MysqlUtils.GetMySqlConnection();
            con.Open();
            //取时间
            int DAY;
            DAY = Convert.ToInt32(daycom.Text);
            string mydatatime;
            mydatatime = DateTime.Now.ToString("yyyy-MM-dd");
            string laterdatatime;
            laterdatatime = DateTime.Now.AddDays(DAY).ToString("yyyy-MM-dd");

            //取书的库存量的值
            /*string bwbk = "";
            bwbk = string.Format(bwbk,);
            MySqlCommand command = new MySqlCommand(bwbk, con);
            MySqlDataReader DR = command.ExecuteReader();
            DR.Read();*/
            int m = 2;//Convert.ToInt32(DR.GetValue(5));
            //取借阅上限和以借阅数
            string owbook = "select * from reader where r_id='{0}'";
            owbook = string.Format(owbook, readertxt.Text);
            MySqlCommand mand = new MySqlCommand(owbook, con);
            MySqlDataReader sw = mand.ExecuteReader();
            sw.Read();
            int n = Convert.ToInt32(sw.GetValue(5));
            int s = Convert.ToInt32(sw.GetValue(6));
            con.Close();

            if (n == s || n>s)
            {
                MessageBox.Show("以达借阅上限");
            }
            else
            {
                if (m < 1)
                {
                    MessageBox.Show("本书库存不足");
                }
                else
                {
                    //con.Open();
                    using (MySqlCommand cmd= new MySqlCommand(xom))
                    {
                        string borr = "insert reader_book values ( '{0}','{1}','{2}','{3}');update reader set borrowed=borrowed+1 where r_id={0};";
                        borr = string.Format(borr, readertxt.Text, Booktxt.Text, mydatatime, laterdatatime);
                        MySqlCommand com = new MySqlCommand(borr, con);
                        com.ExecuteNonQuery();
                        MessageBox.Show("借阅成功");
                    }
                    
                }
            }
                     
        }

        private void cancelbut_Click(object sender, EventArgs e)
        {
            AdminMainForm X = new AdminMainForm();
            X.Show();
            this.Hide();
        }

        private void Borrowbook_Load(object sender, EventArgs e)
        {
            Intday();
        }
    }
}
