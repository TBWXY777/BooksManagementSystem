using ConnectSql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsWithSql
{
    public partial class BookMainForm : Form
    {
        public BookMainForm()
        {
            InitializeComponent();
            MysqlUtils.mainPage = this;
        }

        private void 查询_Click(object sender, EventArgs e)
        {
            new QueryForm().ShowDialog();
        }

        private void initBookListView()
        {
            bookListView.Columns.Add("编号", 100);
            bookListView.Columns.Add("书籍编号", 100);
            bookListView.Columns.Add("书籍名", 100);
            bookListView.Columns.Add("价格", 100);
            flushBookListView();
        }

        public void flushBookListView()
        {
            bookListView.Items.Clear();
            var list = MysqlUtils.Query("select * from book");
            for (int i = 0; i < list.Count; ++i)
            {
                ListViewItem item = new ListViewItem();
                item.Text = list[i]["b_id"].ToString();
                item.SubItems.Add(list[i]["isbn"].ToString());
                item.SubItems.Add(list[i]["book_name"].ToString());
                item.SubItems.Add(list[i]["price"].ToString());
                bookListView.Items.Add(item);
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            initBookListView();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new DetailForm();
            form.txtEdition.Text = "2021年6月第1版";
            form.txtPress.Text = "默认出版社";
            form.txtPubDate.Text =  DateTime.Now.Year + "-"
                        + DateTime.Now.Month + "-" + DateTime.Now.Day;
            form.txtBookId.Text = "ISBN 123-456";
            form.txtPackMode.Text = "缝纫线装";
            form.txtPrice.Text = "123";
            form.txtCount.Text = "6千字";
            form.btnModify.Enabled = false;
            form.ShowDialog();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                var id = bookListView.SelectedItems[0].Text;
                string sql = "delete FROM book where b_id = {0}";
                sql = String.Format(sql, int.Parse(id));
                MysqlUtils.Update(sql);
            }catch(Exception ex)
            {
                MessageBox.Show("异常!请检查是否选中某一行!");
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            var form = initFormText();
            if (form == null) return;//有异常直接结束
            form.btnAdd.Enabled = false;
            form.ShowDialog();
        }

        /// <summary>
        /// 从数据库获取字段 初始化DetailForm 并返回
        /// </summary>
        /// <returns>返回null说明有异常</returns>
        private DetailForm initFormText()
        {
            DataRow row = null;
            try
            {
                var id = bookListView.SelectedItems[0].Text;
                string sql = "select * from book where b_id = {0}";
                sql = String.Format(sql, int.Parse(id));
                row = MysqlUtils.QueryOne(sql);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("异常!请检查是否选中某一行!");
                return null;
            }
            var form = new DetailForm();
            //设置文本框内容
            form.txtEdition.Text = row["edition"].ToString();
            form.txtPress.Text = row["press"].ToString();
            form.txtPubDate.Text = row["pub_date"].ToString();
            form.txtBookId.Text = row["isbn"].ToString();
            form.txtPackMode.Text = row["pack_mode"].ToString();
            form.txtPrice.Text = row["price"].ToString();
            form.txtCount.Text = row["word_count"].ToString();
            form.txtId.Text = row["b_id"].ToString();
            form.txtBookName.Text = row["book_name"].ToString();
            //放置图片
            byte[] byteArr = null;
            if (!(row["pic"] is DBNull)) byteArr = (byte[])row["pic"];
            if (byteArr != null)
            {
                MemoryStream ms = new MemoryStream(byteArr, 0, byteArr.Length);
                form.picBox.Image = Image.FromStream(ms);
                form.picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            return form;
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            var form = initFormText();
            if (form == null) return;//有异常直接结束
            //按钮不可用
            form.btnAdd.Enabled = false;
            form.btnModify.Enabled = false;
            //文本框不可用
            form.txtEdition.Enabled = false;
            form.txtPress.Enabled = false;
            form.txtPubDate.Enabled = false;
            form.txtBookId.Enabled = false;
            form.txtPackMode.Enabled = false;
            form.txtPrice.Enabled = false;
            form.txtCount.Enabled = false;
            form.txtId.Enabled = false;
            form.txtBookName.Enabled = false;
            form.btnUploadPic.Enabled = false;
            form.labelSizeTip.Visible = false;
            form.ShowDialog();
            form.labelSizeTip.Visible = true;
        }
    }
}
