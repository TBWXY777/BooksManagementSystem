
namespace BooksManagementSystem
{
    partial class Borrowbook
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
            this.Booklab = new System.Windows.Forms.Label();
            this.Timebook = new System.Windows.Forms.Label();
            this.Booktxt = new System.Windows.Forms.TextBox();
            this.cancelbut = new System.Windows.Forms.Button();
            this.borrowbut = new System.Windows.Forms.Button();
            this.readerlab = new System.Windows.Forms.Label();
            this.readertxt = new System.Windows.Forms.TextBox();
            this.daycom = new System.Windows.Forms.ComboBox();
            this.daylab = new System.Windows.Forms.Label();
            this.numberlab = new System.Windows.Forms.Label();
            this.numbertxt = new System.Windows.Forms.TextBox();
            this.ben = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Booklab
            // 
            this.Booklab.AutoSize = true;
            this.Booklab.Location = new System.Drawing.Point(84, 83);
            this.Booklab.Name = "Booklab";
            this.Booklab.Size = new System.Drawing.Size(53, 15);
            this.Booklab.TabIndex = 8;
            this.Booklab.Text = "书籍ID";
            // 
            // Timebook
            // 
            this.Timebook.AutoSize = true;
            this.Timebook.Location = new System.Drawing.Point(84, 133);
            this.Timebook.Name = "Timebook";
            this.Timebook.Size = new System.Drawing.Size(67, 15);
            this.Timebook.TabIndex = 9;
            this.Timebook.Text = "借阅时间";
            // 
            // Booktxt
            // 
            this.Booktxt.Location = new System.Drawing.Point(191, 80);
            this.Booktxt.Name = "Booktxt";
            this.Booktxt.Size = new System.Drawing.Size(170, 25);
            this.Booktxt.TabIndex = 2;
            // 
            // cancelbut
            // 
            this.cancelbut.Location = new System.Drawing.Point(283, 233);
            this.cancelbut.Name = "cancelbut";
            this.cancelbut.Size = new System.Drawing.Size(78, 33);
            this.cancelbut.TabIndex = 6;
            this.cancelbut.Text = "取消";
            this.cancelbut.UseVisualStyleBackColor = true;
            this.cancelbut.Click += new System.EventHandler(this.cancelbut_Click);
            // 
            // borrowbut
            // 
            this.borrowbut.Location = new System.Drawing.Point(124, 233);
            this.borrowbut.Name = "borrowbut";
            this.borrowbut.Size = new System.Drawing.Size(75, 33);
            this.borrowbut.TabIndex = 5;
            this.borrowbut.Text = "借阅";
            this.borrowbut.UseVisualStyleBackColor = true;
            this.borrowbut.Click += new System.EventHandler(this.borrowbut_Click);
            // 
            // readerlab
            // 
            this.readerlab.AutoSize = true;
            this.readerlab.Location = new System.Drawing.Point(84, 32);
            this.readerlab.Name = "readerlab";
            this.readerlab.Size = new System.Drawing.Size(53, 15);
            this.readerlab.TabIndex = 7;
            this.readerlab.Text = "读者ID";
            // 
            // readertxt
            // 
            this.readertxt.Location = new System.Drawing.Point(191, 29);
            this.readertxt.Name = "readertxt";
            this.readertxt.Size = new System.Drawing.Size(170, 25);
            this.readertxt.TabIndex = 1;
            // 
            // daycom
            // 
            this.daycom.FormattingEnabled = true;
            this.daycom.Location = new System.Drawing.Point(191, 133);
            this.daycom.Name = "daycom";
            this.daycom.Size = new System.Drawing.Size(48, 23);
            this.daycom.TabIndex = 3;
            // 
            // daylab
            // 
            this.daylab.AutoSize = true;
            this.daylab.Location = new System.Drawing.Point(245, 136);
            this.daylab.Name = "daylab";
            this.daylab.Size = new System.Drawing.Size(22, 15);
            this.daylab.TabIndex = 9;
            this.daylab.Text = "天";
            // 
            // numberlab
            // 
            this.numberlab.AutoSize = true;
            this.numberlab.Location = new System.Drawing.Point(84, 172);
            this.numberlab.Name = "numberlab";
            this.numberlab.Size = new System.Drawing.Size(53, 15);
            this.numberlab.TabIndex = 10;
            this.numberlab.Text = "数  目";
            // 
            // numbertxt
            // 
            this.numbertxt.Location = new System.Drawing.Point(191, 169);
            this.numbertxt.Name = "numbertxt";
            this.numbertxt.Size = new System.Drawing.Size(48, 25);
            this.numbertxt.TabIndex = 4;
            // 
            // ben
            // 
            this.ben.AutoSize = true;
            this.ben.Location = new System.Drawing.Point(245, 172);
            this.ben.Name = "ben";
            this.ben.Size = new System.Drawing.Size(22, 15);
            this.ben.TabIndex = 12;
            this.ben.Text = "本";
            // 
            // Borrowbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 314);
            this.Controls.Add(this.ben);
            this.Controls.Add(this.numbertxt);
            this.Controls.Add(this.numberlab);
            this.Controls.Add(this.daylab);
            this.Controls.Add(this.daycom);
            this.Controls.Add(this.readertxt);
            this.Controls.Add(this.readerlab);
            this.Controls.Add(this.borrowbut);
            this.Controls.Add(this.cancelbut);
            this.Controls.Add(this.Booktxt);
            this.Controls.Add(this.Timebook);
            this.Controls.Add(this.Booklab);
            this.Name = "Borrowbook";
            this.Text = "Borrowbook";
            this.Load += new System.EventHandler(this.Borrowbook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Booklab;
        private System.Windows.Forms.Label Timebook;
        private System.Windows.Forms.TextBox Booktxt;
        private System.Windows.Forms.Button cancelbut;
        private System.Windows.Forms.Button borrowbut;
        private System.Windows.Forms.Label readerlab;
        private System.Windows.Forms.TextBox readertxt;
        private System.Windows.Forms.ComboBox daycom;
        private System.Windows.Forms.Label daylab;
        private System.Windows.Forms.Label numberlab;
        private System.Windows.Forms.TextBox numbertxt;
        private System.Windows.Forms.Label ben;
    }
}