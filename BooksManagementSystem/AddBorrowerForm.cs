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
            string sql = "insert into reader values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";
            sql = String.Format(sql ,id , textBox1.Text, textBox2.Text, textBox3.Text, "0", "3", textBox4.Text);
            var dt = MysqlUtils.Update(sql);
            try
            {
                if (dt!=-1)
                {
                    id++;
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
