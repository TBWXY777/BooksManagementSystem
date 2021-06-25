using ConnectSql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsWithSql
{
    public partial class DetailForm : Form
    {
		public BookMainForm bookMainForm;

        public DetailForm()
        {
            InitializeComponent();
        }
		public DetailForm(BookMainForm bookMainForm)
		{
			InitializeComponent();
			this.bookMainForm = bookMainForm;
		}

		/// <summary>
		/// 判断日期是否合法
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtPubDate_Leave(object sender, EventArgs e)
        {
			if (!RegexUtils.CheckDate(txtPubDate.Text))
			{
				DialogResult dr = MessageBox.Show("输入格式有误，请重新输入，如2021-12-12", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (DialogResult.Yes != dr)//不重新输入
				{
					txtPubDate.Text = DateTime.Now.Year + "-"
						+ DateTime.Now.Month + "-" + DateTime.Now.Day;
				}
				else//重新输入
				{
					txtPubDate.Text = "";
					txtPubDate.Focus();
				}
			}
		}

		/// <summary>
		/// 判断价格是否合法,只能是整数或者带有小数
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void txtPrice_Leave(object sender, EventArgs e)
        {
			if (!RegexUtils.CheckPrice(txtPrice.Text))
			{
				DialogResult dr = MessageBox.Show("输入格式有误，请重新输入，如123.456或123", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (DialogResult.Yes != dr)//不重新输入
				{
					txtPrice.Text = "123";
				}
				else//重新输入
				{
					txtPrice.Text = "";
					txtPrice.Focus();
				}
			}
		}

        private void btnAdd_Click(object sender, EventArgs e)
        {
			String sql = "insert into book VALUES(null,'{0}', '{1}', '{2}','{3}','{4}','{5}',@pic,'{6}', {7})";
			Byte[] byteArr = picPath == null ? null : FileUtils.GetByteFromPath(picPath);
			sql = String.Format(sql, txtBookId.Text, txtPress.Text, txtPubDate.Text, txtEdition.Text, txtCount.Text
				,txtPackMode.Text,txtBookName.Text ,Double.Parse(txtPrice.Text));
			var pairs = new Dictionary<string, Object>();
			pairs.Add("@pic", byteArr);
			var ret = MysqlUtils.Update(sql,pairs);
            if (ret == -1)
            {
				MessageBox.Show("添加失败!");
				return;
            }
			//如果成功 那么重置picPath
			picPath = null;
			if(bookMainForm!=null) bookMainForm.flushBookListView();
		}

        private void btnModify_Click(object sender, EventArgs e)
        {
			String sql = "update book set isbn = '{0}',press = '{1}',pub_date = '{2}',edition = '{3}',word_count = '{4}',pack_mode = '{5}',book_name = '{6}',price = '{7}' where b_id = {8}";
			sql = String.Format(sql, txtBookId.Text, txtPress.Text, txtPubDate.Text, txtEdition.Text, txtCount.Text
				, txtPackMode.Text, txtBookName.Text, Double.Parse(txtPrice.Text),txtId.Text);
			Byte[] byteArr = picPath == null ? null : FileUtils.GetByteFromPath(picPath);
			int ret = -1;
			ret = MysqlUtils.Update(sql);
			//如果图片不修改 或者压根没选择图片 那么直接不管
			if (byteArr!=null)
            {
				sql = "update book set pic = @pic where b_id = {0}";
				sql = String.Format(sql,txtId.Text);
				var pairs = new Dictionary<string, Object>();
				pairs.Add("@pic", byteArr);
				ret = MysqlUtils.Update(sql, pairs);
			}
			if (ret == -1)
			{
				//只要有一个地方修改出现-1 那就是修改失败
				MessageBox.Show("修改失败!");
				return;
            }
			//如果成功 那么重置picPath
			picPath = null;
			if (bookMainForm != null) bookMainForm.flushBookListView();
		}
		private string picPath = null;

        private void btnUploadPic_Click(object sender, EventArgs e)
        {
			openPicDialog.Title = "请选择要上传的图片";
			openPicDialog.Filter = "BMP(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|PNG(*.png)|*.png";
			if(openPicDialog.ShowDialog() == DialogResult.OK)
            {
				picBox.Image = Image.FromFile(openPicDialog.FileName);
				//自动调整大小
				picBox.SizeMode = PictureBoxSizeMode.StretchImage;
				picPath = openPicDialog.FileName;
				var fileInfo = new FileInfo(openPicDialog.FileName);
				double size = fileInfo.Length;
				size /= 1024 * 1024;//转为MB
				labelPicSize.Text = String.Format("当前为{0:F}MB",size);
			}
		}

        private void DetailForm_Load(object sender, EventArgs e)
        {

        }
    }
}
