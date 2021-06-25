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
    public partial class AddBorrowerForm : Form
    {
        public AddBorrowerForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection con;
            con = MysqlUtils.GetMySqlConnection();
            con.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = con;
            command.CommandText = "insert into reader(r_id,r_name,major,dep,borrowed,all_borrow,r_pwd) values(''" + "','" + textBox1.Text +  //姓名
                "','" + textBox2.Text +  //专业
                "','" + textBox3.Text +  //学院
                "','" + '0' +//已借
                "','" + '3' +//可借
                "','" + textBox4.Text + "')";//密码
            try
            {
                if (command.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("添加成功");
                    con.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("添加失败");
                    con.Close();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("该名读者已存在，请前往查找验证");
            }
        }
    }
}
