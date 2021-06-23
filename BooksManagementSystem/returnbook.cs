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
                string strfz = "select * from reader_book where r_id='{0}'";
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

            MySql.Data.MySqlClient.MySqlConnection con;
            con = MysqlUtils.GetMySqlConnection();
            con.Open();
            string xom;
            xom = MysqlUtils.connectStr;
            //归还操作
            using (MySqlCommand cmd = new MySqlCommand(xom))
            {
                string strfz = "delete from reader_book where b_id={0};update reader set borrowed=borrowed-1 where r_id={1}";
                strfz = string.Format(strfz, bid, readertxt1.Text);
                MySqlCommand command = new MySqlCommand(strfz, con);
                command.ExecuteNonQuery();
                MessageBox.Show("归还成功");
                //归还后显示
                string retu = "select * from reader_book where r_id='{0}'";
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
