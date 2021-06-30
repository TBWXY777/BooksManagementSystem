
namespace WindowsFormsWithSql
{
    partial class QueryForm
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.radioBtnBname = new System.Windows.Forms.RadioButton();
            this.radioBtnBid = new System.Windows.Forms.RadioButton();
            this.bookGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bookGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(73, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入书名或编号:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(325, 72);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(472, 25);
            this.txtInput.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(545, 153);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(175, 60);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // radioBtnBname
            // 
            this.radioBtnBname.AutoSize = true;
            this.radioBtnBname.Checked = true;
            this.radioBtnBname.Location = new System.Drawing.Point(325, 153);
            this.radioBtnBname.Name = "radioBtnBname";
            this.radioBtnBname.Size = new System.Drawing.Size(58, 19);
            this.radioBtnBname.TabIndex = 3;
            this.radioBtnBname.TabStop = true;
            this.radioBtnBname.Text = "书名";
            this.radioBtnBname.UseVisualStyleBackColor = true;
            // 
            // radioBtnBid
            // 
            this.radioBtnBid.AutoSize = true;
            this.radioBtnBid.Location = new System.Drawing.Point(325, 194);
            this.radioBtnBid.Name = "radioBtnBid";
            this.radioBtnBid.Size = new System.Drawing.Size(58, 19);
            this.radioBtnBid.TabIndex = 4;
            this.radioBtnBid.Text = "编号";
            this.radioBtnBid.UseVisualStyleBackColor = true;
            // 
            // bookGridView
            // 
            this.bookGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookGridView.Location = new System.Drawing.Point(16, 233);
            this.bookGridView.Name = "bookGridView";
            this.bookGridView.RowHeadersWidth = 51;
            this.bookGridView.RowTemplate.Height = 27;
            this.bookGridView.Size = new System.Drawing.Size(831, 305);
            this.bookGridView.TabIndex = 5;
            // 
            // QueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 550);
            this.Controls.Add(this.bookGridView);
            this.Controls.Add(this.radioBtnBid);
            this.Controls.Add(this.radioBtnBname);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Name = "QueryForm";
            this.Text = "QueryForm";
            this.Load += new System.EventHandler(this.QueryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.RadioButton radioBtnBname;
        private System.Windows.Forms.RadioButton radioBtnBid;
        private System.Windows.Forms.DataGridView bookGridView;
    }
}