using ConnectSql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace BooksManagementSystem
{
    public partial class ModifyJumpScript : Form
    {
        public ModifyJumpScript()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModifyBorrowerForm m = new ModifyBorrowerForm();
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("请输入编号");
                return;
            }
            if (!Isnum(textBox1.Text))
            {
                MessageBox.Show("请输入正确编号");
                return;
            }
            m.getID = textBox1.Text;
            m.Show();
        }
        private bool Isnum(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                int temp = (int)s[i];
                if (temp >= 48 && temp <= 57)
                {
                    continue;
                }
                else
                    return false;
            }
            return true;
        }
    }
}
