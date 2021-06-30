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
    public partial class Readerborrowbook : Form
    {
        public string Rid;
        public Readerborrowbook()
        {
            InitializeComponent();
            r_numbertxt.Text = Convert.ToString(1);
        }
        public Readerborrowbook(string id)
        {
            InitializeComponent();
            r_numbertxt.Text = Convert.ToString(1);
            Rid = id;
        }
        public void R_Intday()
        {
            r_daycom.Items.Add("1");
            r_daycom.Items.Add("3");
            r_daycom.Items.Add("7");
        }
        private void r_borrowbut_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection con;
            string xom;
            xom = MysqlUtils.connectStr;
            con = MysqlUtils.GetMySqlConnection();
            con.Open();

            //取时间
            int DAY;
            DAY = Convert.ToInt32(r_daycom.Text);
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
            owbook = string.Format(owbook, Rid);
            MySqlCommand mand = new MySqlCommand(owbook, con);
            MySqlDataReader sw = mand.ExecuteReader();
            sw.Read();
            int n = Convert.ToInt32(sw.GetValue(5));
            int s = Convert.ToInt32(sw.GetValue(6));
            con.Close();

            if (n == s || n > s)
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
                    int num = Convert.ToInt32(r_numbertxt.Text);
                    //借阅功能
                    string borr = "insert into reader_book values (null, '{0}','{1}','{2}',NULL,'{4}','{3}','{4}');";
                    borr = string.Format(borr, Rid, r_bookidtxt.Text, mydatatime, laterdatatime, num);
                    MysqlUtils.Update(borr);    
                    MessageBox.Show("借阅成功");

                    string sql = "update reader set borrowed=borrowed+{1} where r_id={0};";
                    sql = string.Format(sql, Rid,num);
                    MysqlUtils.Update(sql);
                }
            }
        }

        private void r_daycom_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void r_cancelbut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Readerborrowbook_Load(object sender, EventArgs e)
        {
            R_Intday();
        }
    }
}
