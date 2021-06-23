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

namespace BooksManagementSystem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text.Trim();//获取文本框内容
            string password = textBox2.Text.Trim();
            if (name.Equals("") || password.Equals(""))
            {
                MessageBox.Show("用户名或密码不能为空！");
            }
            else
            {
                try
                {
                    MysqlUtils.GetMySqlConnection().Open();

                    string sql1 = "select r_id,r_pwd from reader where r_id ='" + name + " ' and  r_pwd = '" + password + "'";
                    string sql2 = "select a_id,a_pwd from admin where a_id ='" + name + " ' and  a_pwd = '" + password + "'";
                    MySqlCommand com1 = new MySqlCommand(sql1, MysqlUtils.GetMySqlConnection());
                    MySqlCommand com2 = new MySqlCommand(sql2, MysqlUtils.GetMySqlConnection());
                    MySqlDataAdapter da1 = new MySqlDataAdapter(com1);
                    MySqlDataAdapter da2 = new MySqlDataAdapter(com2);
                    DataSet ds = new DataSet();
                    int n = da1.Fill(ds, "register");
                    int m = da2.Fill(ds, "register");

                    if (n != 0)
                    {
                        MessageBox.Show("登录成功!");
                        this.DialogResult = DialogResult.OK;
                        this.Dispose();
                        this.Close();
                    }
                    else if (m != 0)
                    {
                        MessageBox.Show("登录成功！");
                        this.DialogResult = DialogResult.Yes;
                        this.Dispose();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误！");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show("打开数据库失败！");

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
