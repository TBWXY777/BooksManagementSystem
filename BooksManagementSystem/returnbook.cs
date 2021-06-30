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
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace BooksManagementSystem
{
    public partial class returnbook : Form
    {
        public returnbook()
        {
            InitializeComponent();
        }

        private void inquirelab_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection con;
            con = MysqlUtils.GetMySqlConnection();
            con.Open();
            string xom;
            xom = MysqlUtils.connectStr;
            //查询读者的借阅情况
            using (MySqlCommand cmd = new MySqlCommand(xom))
            {
                string strfz = "select * from reader_book where r_id='{0}' and waited_return_number !=0";
                strfz = string.Format(strfz, readertxt1.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(strfz, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataView1.DataSource = ds.Tables[0].DefaultView;
            }
        }

        private void returnlab_Click(object sender, EventArgs e)
        {
            string bid = dataView1.CurrentRow.Cells["b_id"].Value.ToString();

            string datatime;
            datatime = DateTime.Now.ToString("yyyy-MM-dd");

            //归还操作
            string strfz = "update reader_book set return_date='{0}',waited_return_number=waited_return_number-1  where r_id={1} and b_id={2};";
            strfz = string.Format(strfz, datatime, readertxt1.Text, bid);
            MysqlUtils.Update(strfz);
            string uped = "update reader set borrowed=borrowed-1 where r_id={0}";
            uped = string.Format(uped, readertxt1.Text);
            MysqlUtils.Update(uped);
            MessageBox.Show("归还成功");

            //归还后显示
            MySql.Data.MySqlClient.MySqlConnection con;
            con = MysqlUtils.GetMySqlConnection();
            con.Open();
            string xom;
            xom = MysqlUtils.connectStr;
            using (MySqlCommand cmd = new MySqlCommand(xom))
            {
                string retu = "select * from reader_book where r_id='{0}'and waited_return_number !=0;";
                retu = string.Format(retu, readertxt1.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(retu, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataView1.DataSource = ds.Tables[0].DefaultView;
            }
            
        }

        private void cancelbut1_Click(object sender, EventArgs e)
        {
            AdminMainForm X = new AdminMainForm();
            X.Show();
            this.Hide();
        }
    }
}
