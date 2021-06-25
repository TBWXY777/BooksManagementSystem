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
            MySqlCommand command = new MySqlCommand();
            command.CommandText= "select * form reader where r_id='" + textBox1 + "' and r_name='" + textBox2 + "'";
            //string sql = "select * form reader where r_id='"+textBox1+"' and r_name='"+textBox2+"'";
            //sql = string.Format(sql, textBox1.Text,textBox2.Text);
            dataGridView1.Columns.Add("1","r_id");
            dataGridView1.Columns.Add("2", "r_name");
            dataGridView1.Columns.Add("3", "major");
            dataGridView1.Columns.Add("4", "dep");
            dataGridView1.Columns.Add("5", "borrowed");
            dataGridView1.Columns.Add("6", "allow_borrow");
            dataGridView1.Columns.Add("7", "r_pwd");
            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    this.dataGridView1.Rows.Add(reader["r_id"].ToString(), reader["r_name"].ToString(), reader["major"].ToString(), reader["dep"].ToString(), reader["borrowed"].ToString(), reader["allow_borrow"].ToString(), reader["r_pwd"].ToString());
                }
                con.Close();
                reader.Close();
            }
            else
            {
                MessageBox.Show("查无此人");
                this.Close();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
