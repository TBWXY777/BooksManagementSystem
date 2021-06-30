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
    public partial class ModifyBorrowerForm : Form
    {
        public string getID;

        public ModifyBorrowerForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyBorrowerForm_Load(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection con;
            con = MysqlUtils.GetMySqlConnection();
            con.Open();
            MySqlCommand command = new MySqlCommand();
            string sql = "select * from reader where r_id='" + getID + "'";
            var dataRow = MysqlUtils.QueryOne(sql);         
            textBox2.Text = dataRow["r_name"].ToString();
            textBox3.Text = dataRow["major"].ToString();
            textBox5.Text = dataRow["dep"].ToString();
            textBox4.Text = dataRow["borrowed"].ToString();
            textBox6.Text = dataRow["allow_borrow"].ToString();
            textBox7.Text = dataRow["r_pwd"].ToString();
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection con;
            con = MysqlUtils.GetMySqlConnection();
            con.Open();
            string sql = "update reader set r_name='{1}',major='{2}',dep='{3}',borrowed='{4}',allow_borrow='{5}',r_pwd='{6}' where r_id='{0}'";
            sql = String.Format(sql, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text,textBox6.Text,textBox7.Text,getID);
            var dt = MysqlUtils.Update(sql);
            if (dt!=-1)
            {
                MessageBox.Show("修改成功！");
                con.Close();
            }
            else
            {
                MessageBox.Show("修改失败！");
                con.Close();
            }
            con.Close();
        }
    }
}
