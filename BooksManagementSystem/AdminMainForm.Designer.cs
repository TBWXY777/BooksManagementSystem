
namespace BooksManagementSystem
{
    partial class AdminMainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.书籍维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加读者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除读者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新读者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询读者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.书籍表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者书籍表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.书籍书架表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理员表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.returnbut2 = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 30);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.书籍维护ToolStripMenuItem,
            this.读者维护ToolStripMenuItem,
            this.查看数据库ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 30);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 书籍维护ToolStripMenuItem
            // 
            this.书籍维护ToolStripMenuItem.Name = "书籍维护ToolStripMenuItem";
            this.书籍维护ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.书籍维护ToolStripMenuItem.Text = "书库维护";
            this.书籍维护ToolStripMenuItem.Click += new System.EventHandler(this.书籍维护ToolStripMenuItem_Click);
            // 
            // 读者维护ToolStripMenuItem
            // 
            this.读者维护ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加读者ToolStripMenuItem,
            this.删除读者ToolStripMenuItem,
            this.更新读者ToolStripMenuItem,
            this.查询读者ToolStripMenuItem});
            this.读者维护ToolStripMenuItem.Name = "读者维护ToolStripMenuItem";
            this.读者维护ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.读者维护ToolStripMenuItem.Text = "读者维护";
            // 
            // 添加读者ToolStripMenuItem
            // 
            this.添加读者ToolStripMenuItem.Name = "添加读者ToolStripMenuItem";
            this.添加读者ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.添加读者ToolStripMenuItem.Text = "添加读者";
            this.添加读者ToolStripMenuItem.Click += new System.EventHandler(this.添加读者ToolStripMenuItem_Click);
            // 
            // 删除读者ToolStripMenuItem
            // 
            this.删除读者ToolStripMenuItem.Name = "删除读者ToolStripMenuItem";
            this.删除读者ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.删除读者ToolStripMenuItem.Text = "删除读者";
            this.删除读者ToolStripMenuItem.Click += new System.EventHandler(this.删除读者ToolStripMenuItem_Click);
            // 
            // 更新读者ToolStripMenuItem
            // 
            this.更新读者ToolStripMenuItem.Name = "更新读者ToolStripMenuItem";
            this.更新读者ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.更新读者ToolStripMenuItem.Text = "更新读者";
            this.更新读者ToolStripMenuItem.Click += new System.EventHandler(this.更新读者ToolStripMenuItem_Click);
            // 
            // 查询读者ToolStripMenuItem
            // 
            this.查询读者ToolStripMenuItem.Name = "查询读者ToolStripMenuItem";
            this.查询读者ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.查询读者ToolStripMenuItem.Text = "查询读者";
            this.查询读者ToolStripMenuItem.Click += new System.EventHandler(this.查询读者ToolStripMenuItem_Click);
            // 
            // 查看数据库ToolStripMenuItem
            // 
            this.查看数据库ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.读者表ToolStripMenuItem,
            this.书籍表ToolStripMenuItem,
            this.读者书籍表ToolStripMenuItem,
            this.书籍书架表ToolStripMenuItem,
            this.管理员表ToolStripMenuItem});
            this.查看数据库ToolStripMenuItem.Name = "查看数据库ToolStripMenuItem";
            this.查看数据库ToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.查看数据库ToolStripMenuItem.Text = "查看数据库";
            // 
            // 读者表ToolStripMenuItem
            // 
            this.读者表ToolStripMenuItem.Name = "读者表ToolStripMenuItem";
            this.读者表ToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.读者表ToolStripMenuItem.Text = "读者表";
            this.读者表ToolStripMenuItem.Click += new System.EventHandler(this.读者表ToolStripMenuItem_Click);
            // 
            // 书籍表ToolStripMenuItem
            // 
            this.书籍表ToolStripMenuItem.Name = "书籍表ToolStripMenuItem";
            this.书籍表ToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.书籍表ToolStripMenuItem.Text = "书籍表";
            this.书籍表ToolStripMenuItem.Click += new System.EventHandler(this.书籍表ToolStripMenuItem_Click);
            // 
            // 读者书籍表ToolStripMenuItem
            // 
            this.读者书籍表ToolStripMenuItem.Name = "读者书籍表ToolStripMenuItem";
            this.读者书籍表ToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.读者书籍表ToolStripMenuItem.Text = "读者-书籍表";
            this.读者书籍表ToolStripMenuItem.Click += new System.EventHandler(this.读者书籍表ToolStripMenuItem_Click);
            // 
            // 书籍书架表ToolStripMenuItem
            // 
            this.书籍书架表ToolStripMenuItem.Name = "书籍书架表ToolStripMenuItem";
            this.书籍书架表ToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.书籍书架表ToolStripMenuItem.Text = "书籍-书架表";
            this.书籍书架表ToolStripMenuItem.Click += new System.EventHandler(this.书籍书架表ToolStripMenuItem_Click);
            // 
            // 管理员表ToolStripMenuItem
            // 
            this.管理员表ToolStripMenuItem.Name = "管理员表ToolStripMenuItem";
            this.管理员表ToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.管理员表ToolStripMenuItem.Text = "管理员表";
            this.管理员表ToolStripMenuItem.Click += new System.EventHandler(this.管理员表ToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(462, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "借阅";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // returnbut2
            // 
            this.returnbut2.Location = new System.Drawing.Point(462, 149);
            this.returnbut2.Name = "returnbut2";
            this.returnbut2.Size = new System.Drawing.Size(75, 23);
            this.returnbut2.TabIndex = 5;
            this.returnbut2.Text = "归还";
            this.returnbut2.UseVisualStyleBackColor = true;
            this.returnbut2.Click += new System.EventHandler(this.returnbut2_Click);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returnbut2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminMainForm_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 书籍维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读者维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加读者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除读者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新读者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询读者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看数据库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读者表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 书籍表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读者书籍表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 书籍书架表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理员表ToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button returnbut2;
    }
}

