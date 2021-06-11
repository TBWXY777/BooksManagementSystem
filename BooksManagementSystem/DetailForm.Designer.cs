
namespace WindowsFormsWithSql
{
    partial class DetailForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtPress = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtEdition = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPubDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPackMode = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.openPicDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnUploadPic = new System.Windows.Forms.Button();
            this.labelSizeTip = new System.Windows.Forms.Label();
            this.labelPicSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "书籍编号";
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(145, 80);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(210, 25);
            this.txtBookId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "书籍名字";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "出版社";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "价格";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "字数";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "版次";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(145, 126);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(210, 25);
            this.txtBookName.TabIndex = 7;
            // 
            // txtPress
            // 
            this.txtPress.Location = new System.Drawing.Point(145, 170);
            this.txtPress.Name = "txtPress";
            this.txtPress.Size = new System.Drawing.Size(210, 25);
            this.txtPress.TabIndex = 8;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(145, 214);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(210, 25);
            this.txtPrice.TabIndex = 9;
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(145, 254);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(210, 25);
            this.txtCount.TabIndex = 10;
            // 
            // txtEdition
            // 
            this.txtEdition.Location = new System.Drawing.Point(145, 299);
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.Size = new System.Drawing.Size(210, 25);
            this.txtEdition.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "出版时间";
            // 
            // txtPubDate
            // 
            this.txtPubDate.Location = new System.Drawing.Point(145, 349);
            this.txtPubDate.Name = "txtPubDate";
            this.txtPubDate.Size = new System.Drawing.Size(210, 25);
            this.txtPubDate.TabIndex = 13;
            this.txtPubDate.Leave += new System.EventHandler(this.txtPubDate_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "包装方式";
            // 
            // txtPackMode
            // 
            this.txtPackMode.Location = new System.Drawing.Point(145, 399);
            this.txtPackMode.Name = "txtPackMode";
            this.txtPackMode.Size = new System.Drawing.Size(210, 25);
            this.txtPackMode.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(422, 352);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 47);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(583, 352);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(130, 47);
            this.btnModify.TabIndex = 17;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(145, 33);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(210, 25);
            this.txtId.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "编号";
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(422, 33);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(337, 228);
            this.picBox.TabIndex = 20;
            this.picBox.TabStop = false;
            // 
            // openPicDialog
            // 
            this.openPicDialog.FileName = "openFileDialog1";
            // 
            // btnUploadPic
            // 
            this.btnUploadPic.Location = new System.Drawing.Point(422, 286);
            this.btnUploadPic.Name = "btnUploadPic";
            this.btnUploadPic.Size = new System.Drawing.Size(130, 47);
            this.btnUploadPic.TabIndex = 21;
            this.btnUploadPic.Text = "选择图片";
            this.btnUploadPic.UseVisualStyleBackColor = true;
            this.btnUploadPic.Click += new System.EventHandler(this.btnUploadPic_Click);
            // 
            // labelSizeTip
            // 
            this.labelSizeTip.AutoSize = true;
            this.labelSizeTip.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSizeTip.Location = new System.Drawing.Point(558, 313);
            this.labelSizeTip.Name = "labelSizeTip";
            this.labelSizeTip.Size = new System.Drawing.Size(199, 20);
            this.labelSizeTip.TabIndex = 22;
            this.labelSizeTip.Text = "图片大小不得超过5MB";
            // 
            // labelPicSize
            // 
            this.labelPicSize.AutoSize = true;
            this.labelPicSize.Location = new System.Drawing.Point(559, 286);
            this.labelPicSize.Name = "labelPicSize";
            this.labelPicSize.Size = new System.Drawing.Size(0, 15);
            this.labelPicSize.TabIndex = 23;
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPicSize);
            this.Controls.Add(this.labelSizeTip);
            this.Controls.Add(this.btnUploadPic);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPackMode);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPubDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEdition);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtPress);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.label1);
            this.Name = "DetailForm";
            this.Text = "DetailForm";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.TextBox txtBookName;
        public System.Windows.Forms.TextBox txtPress;
        public System.Windows.Forms.TextBox txtPrice;
        public System.Windows.Forms.TextBox txtCount;
        public System.Windows.Forms.TextBox txtEdition;
        public System.Windows.Forms.TextBox txtPubDate;
        public System.Windows.Forms.TextBox txtPackMode;
        public System.Windows.Forms.TextBox txtBookId;
        public System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.OpenFileDialog openPicDialog;
        public System.Windows.Forms.Button btnUploadPic;
        public System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label labelPicSize;
        public System.Windows.Forms.Label labelSizeTip;
    }
}