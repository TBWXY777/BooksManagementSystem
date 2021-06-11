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

namespace WindowsFormsWithSql
{
    public partial class QueryForm : Form
    {
        public QueryForm()
        {
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string sql = "select * From book where {0} = '{1}'";
            //二选一
            if (radioBtnBid.Checked)
            {
                sql = String.Format(sql, "b_id", txtInput.Text);
            }
            else
            {
                sql = String.Format(sql, "book_name", txtInput.Text);
            }
            var dt = MysqlUtils.QueryToDataTable(sql);
            bookGridView.DataSource = dt;
            ((DataGridViewImageColumn)bookGridView.Columns["pic"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
        }
    }
}
