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
    public partial class SearchBorrowerForm : Form
    {
        public SearchBorrowerForm()
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
            string sql= "select * from reader where {0} = '{1}' and {2} = '{3}'";
            sql = String.Format(sql, "r_id", textBox1.Text,"r_name",textBox2.Text);
            var dt = MysqlUtils.QueryToDataTable(sql);
            dataGridView1.DataSource = dt;
            con.Close();          
        }
    }
}
