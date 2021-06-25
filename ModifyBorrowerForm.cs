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
            command.CommandText = "select * from reader where r_id='" + textBox1 + "'";
            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                //textBox1.Text = reader["r_id"].ToString();
                textBox2.Text = reader["r_name"].ToString();
                textBox3.Text = reader["major"].ToString();
                textBox5.Text = reader["dep"].ToString();
                textBox4.Text = reader["borrowed"].ToString();
                textBox6.Text = reader["allow_borrow"].ToString();
                textBox7.Text = reader["r_pwd"].ToString();
            }
            else
            {
                MessageBox.Show("该读者不存在");
                this.Close();

            }
            reader.Close();
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection con;
            con = MysqlUtils.GetMySqlConnection();
            con.Open();
            MySqlCommand command = new MySqlCommand();
            command.CommandText = "select * from reader where r_id='" + textBox1 + "'";
            var reader = command.ExecuteReader();
            command.CommandText = "update reader set " +
                   "r_name='" + textBox2.Text +
                   "',major='" + textBox3.Text +
                   "',dep='" + textBox4.Text +
                   "',borrowed='" + textBox5.Text +
                   "',allow_borrow='" + textBox6.Text +
                   "',r_pwd='" + textBox7.Text +
                   "' where r_id='" + textBox1 + "'";
            if (command.ExecuteNonQuery() != 0)
            {
                MessageBox.Show("修改成功！");
                con.Close();
            }
            else
            {
                MessageBox.Show("修改失败！");
                con.Close();
            }

        }
    }
}
