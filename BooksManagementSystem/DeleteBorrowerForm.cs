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
    public partial class DeleteBorrowerForm : Form
    {
        public DeleteBorrowerForm()
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
            string sql = "delete from reader where {0} = '{1}'";
            sql = String.Format(sql,"r_id" ,textBox1.Text);
            var dt = MysqlUtils.Update(sql);
            try
            {
                if (dt!=-1)
                {
                    MessageBox.Show("删除成功");
                    con.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
            catch
            {
                MessageBox.Show("查无此人");
                con.Close();
                return;
            }
            con.Close();

        }
    }
}
