
namespace WindowsFormsWithSql
{
    partial class BookMainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bookListView = new System.Windows.Forms.ListView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.查询 = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // bookListView
            // 
            this.bookListView.FullRowSelect = true;
            this.bookListView.HideSelection = false;
            this.bookListView.Location = new System.Drawing.Point(321, 12);
            this.bookListView.Name = "bookListView";
            this.bookListView.Size = new System.Drawing.Size(533, 513);
            this.bookListView.TabIndex = 0;
            this.bookListView.UseCompatibleStateImageBehavior = false;
            this.bookListView.View = System.Windows.Forms.View.Details;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(45, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 68);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(45, 109);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(136, 68);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(45, 213);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(136, 68);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // 查询
            // 
            this.查询.Location = new System.Drawing.Point(45, 317);
            this.查询.Name = "查询";
            this.查询.Size = new System.Drawing.Size(136, 68);
            this.查询.TabIndex = 4;
            this.查询.Text = "查询";
            this.查询.UseVisualStyleBackColor = true;
            this.查询.Click += new System.EventHandler(this.查询_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(45, 424);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(136, 68);
            this.btnDetail.TabIndex = 5;
            this.btnDetail.Text = "详细";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // BookMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 537);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.查询);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.bookListView);
            this.Name = "BookMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookMainForm";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView bookListView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button 查询;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

