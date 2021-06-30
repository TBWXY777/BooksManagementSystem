
namespace BooksManagementSystem
{
    partial class returnbook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cancelbut1 = new System.Windows.Forms.Button();
            this.inquirelab = new System.Windows.Forms.Button();
            this.returnlab = new System.Windows.Forms.Button();
            this.readertxt1 = new System.Windows.Forms.TextBox();
            this.readerlab1 = new System.Windows.Forms.Label();
            this.dataView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cancelbut1);
            this.splitContainer1.Panel1.Controls.Add(this.inquirelab);
            this.splitContainer1.Panel1.Controls.Add(this.returnlab);
            this.splitContainer1.Panel1.Controls.Add(this.readertxt1);
            this.splitContainer1.Panel1.Controls.Add(this.readerlab1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataView1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 119;
            this.splitContainer1.TabIndex = 0;
            // 
            // cancelbut1
            // 
            this.cancelbut1.Location = new System.Drawing.Point(535, 81);
            this.cancelbut1.Name = "cancelbut1";
            this.cancelbut1.Size = new System.Drawing.Size(84, 35);
            this.cancelbut1.TabIndex = 4;
            this.cancelbut1.Text = "取消";
            this.cancelbut1.UseVisualStyleBackColor = true;
            this.cancelbut1.Click += new System.EventHandler(this.cancelbut1_Click);
            // 
            // inquirelab
            // 
            this.inquirelab.Location = new System.Drawing.Point(175, 82);
            this.inquirelab.Name = "inquirelab";
            this.inquirelab.Size = new System.Drawing.Size(88, 35);
            this.inquirelab.TabIndex = 3;
            this.inquirelab.Text = "查询";
            this.inquirelab.UseVisualStyleBackColor = true;
            this.inquirelab.Click += new System.EventHandler(this.inquirelab_Click);
            // 
            // returnlab
            // 
            this.returnlab.Location = new System.Drawing.Point(353, 81);
            this.returnlab.Name = "returnlab";
            this.returnlab.Size = new System.Drawing.Size(85, 36);
            this.returnlab.TabIndex = 2;
            this.returnlab.Text = "归还";
            this.returnlab.UseVisualStyleBackColor = true;
            this.returnlab.Click += new System.EventHandler(this.returnlab_Click);
            // 
            // readertxt1
            // 
            this.readertxt1.Location = new System.Drawing.Point(315, 28);
            this.readertxt1.Name = "readertxt1";
            this.readertxt1.Size = new System.Drawing.Size(174, 25);
            this.readertxt1.TabIndex = 1;
            // 
            // readerlab1
            // 
            this.readerlab1.AutoSize = true;
            this.readerlab1.Location = new System.Drawing.Point(210, 31);
            this.readerlab1.Name = "readerlab1";
            this.readerlab1.Size = new System.Drawing.Size(53, 15);
            this.readerlab1.TabIndex = 0;
            this.readerlab1.Text = "读者ID";
            // 
            // dataView1
            // 
            this.dataView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataView1.Location = new System.Drawing.Point(0, 0);
            this.dataView1.Name = "dataView1";
            this.dataView1.RowHeadersWidth = 51;
            this.dataView1.RowTemplate.Height = 27;
            this.dataView1.Size = new System.Drawing.Size(800, 327);
            this.dataView1.TabIndex = 2;
            // 
            // returnbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "returnbook";
            this.Text = "returnbook";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button inquirelab;
        private System.Windows.Forms.Button returnlab;
        private System.Windows.Forms.TextBox readertxt1;
        private System.Windows.Forms.Label readerlab1;
        private System.Windows.Forms.DataGridView dataView1;
        private System.Windows.Forms.Button cancelbut1;
    }
}