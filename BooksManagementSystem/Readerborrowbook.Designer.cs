
namespace BooksManagementSystem
{
    partial class Readerborrowbook
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
            this.r_bookidlab = new System.Windows.Forms.Label();
            this.r_datetimelab = new System.Windows.Forms.Label();
            this.r_booklab = new System.Windows.Forms.Label();
            this.r_day = new System.Windows.Forms.Label();
            this.r__book = new System.Windows.Forms.Label();
            this.r_bookidtxt = new System.Windows.Forms.TextBox();
            this.r_numbertxt = new System.Windows.Forms.TextBox();
            this.r_cancelbut = new System.Windows.Forms.Button();
            this.r_borrowbut = new System.Windows.Forms.Button();
            this.r_daycom = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // r_bookidlab
            // 
            this.r_bookidlab.AutoSize = true;
            this.r_bookidlab.Location = new System.Drawing.Point(106, 53);
            this.r_bookidlab.Name = "r_bookidlab";
            this.r_bookidlab.Size = new System.Drawing.Size(53, 15);
            this.r_bookidlab.TabIndex = 0;
            this.r_bookidlab.Text = "书籍ID";
            // 
            // r_datetimelab
            // 
            this.r_datetimelab.AutoSize = true;
            this.r_datetimelab.Location = new System.Drawing.Point(106, 117);
            this.r_datetimelab.Name = "r_datetimelab";
            this.r_datetimelab.Size = new System.Drawing.Size(67, 15);
            this.r_datetimelab.TabIndex = 1;
            this.r_datetimelab.Text = "借阅时间";
            // 
            // r_booklab
            // 
            this.r_booklab.AutoSize = true;
            this.r_booklab.Location = new System.Drawing.Point(106, 165);
            this.r_booklab.Name = "r_booklab";
            this.r_booklab.Size = new System.Drawing.Size(53, 15);
            this.r_booklab.TabIndex = 2;
            this.r_booklab.Text = "数  目";
            // 
            // r_day
            // 
            this.r_day.AutoSize = true;
            this.r_day.Location = new System.Drawing.Point(221, 120);
            this.r_day.Name = "r_day";
            this.r_day.Size = new System.Drawing.Size(22, 15);
            this.r_day.TabIndex = 3;
            this.r_day.Text = "天";
            // 
            // r__book
            // 
            this.r__book.AutoSize = true;
            this.r__book.Location = new System.Drawing.Point(221, 165);
            this.r__book.Name = "r__book";
            this.r__book.Size = new System.Drawing.Size(22, 15);
            this.r__book.TabIndex = 4;
            this.r__book.Text = "本";
            // 
            // r_bookidtxt
            // 
            this.r_bookidtxt.Location = new System.Drawing.Point(167, 50);
            this.r_bookidtxt.Name = "r_bookidtxt";
            this.r_bookidtxt.Size = new System.Drawing.Size(168, 25);
            this.r_bookidtxt.TabIndex = 1;
            // 
            // r_numbertxt
            // 
            this.r_numbertxt.Location = new System.Drawing.Point(167, 162);
            this.r_numbertxt.Name = "r_numbertxt";
            this.r_numbertxt.Size = new System.Drawing.Size(48, 25);
            this.r_numbertxt.TabIndex = 3;
            // 
            // r_cancelbut
            // 
            this.r_cancelbut.Location = new System.Drawing.Point(296, 255);
            this.r_cancelbut.Name = "r_cancelbut";
            this.r_cancelbut.Size = new System.Drawing.Size(75, 23);
            this.r_cancelbut.TabIndex = 8;
            this.r_cancelbut.Text = "取消";
            this.r_cancelbut.UseVisualStyleBackColor = true;
            this.r_cancelbut.Click += new System.EventHandler(this.r_cancelbut_Click);
            // 
            // r_borrowbut
            // 
            this.r_borrowbut.Location = new System.Drawing.Point(61, 255);
            this.r_borrowbut.Name = "r_borrowbut";
            this.r_borrowbut.Size = new System.Drawing.Size(75, 23);
            this.r_borrowbut.TabIndex = 9;
            this.r_borrowbut.Text = "借阅";
            this.r_borrowbut.UseVisualStyleBackColor = true;
            this.r_borrowbut.Click += new System.EventHandler(this.r_borrowbut_Click);
            // 
            // r_daycom
            // 
            this.r_daycom.FormattingEnabled = true;
            this.r_daycom.Location = new System.Drawing.Point(167, 117);
            this.r_daycom.Name = "r_daycom";
            this.r_daycom.Size = new System.Drawing.Size(48, 23);
            this.r_daycom.TabIndex = 10;
            this.r_daycom.SelectedIndexChanged += new System.EventHandler(this.r_daycom_SelectedIndexChanged);
            // 
            // Readerborrowbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 337);
            this.Controls.Add(this.r_daycom);
            this.Controls.Add(this.r_borrowbut);
            this.Controls.Add(this.r_cancelbut);
            this.Controls.Add(this.r_numbertxt);
            this.Controls.Add(this.r_bookidtxt);
            this.Controls.Add(this.r__book);
            this.Controls.Add(this.r_day);
            this.Controls.Add(this.r_booklab);
            this.Controls.Add(this.r_datetimelab);
            this.Controls.Add(this.r_bookidlab);
            this.Name = "Readerborrowbook";
            this.Text = "Readerborrowbook";
            this.Load += new System.EventHandler(this.Readerborrowbook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label r_bookidlab;
        private System.Windows.Forms.Label r_datetimelab;
        private System.Windows.Forms.Label r_booklab;
        private System.Windows.Forms.Label r_day;
        private System.Windows.Forms.Label r__book;
        private System.Windows.Forms.TextBox r_bookidtxt;
        private System.Windows.Forms.TextBox r_numbertxt;
        private System.Windows.Forms.Button r_cancelbut;
        private System.Windows.Forms.Button r_borrowbut;
        private System.Windows.Forms.ComboBox r_daycom;
    }
}