
namespace week12_ques2
{
    partial class writeBtn
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
            this.inputTxb = new System.Windows.Forms.TextBox();
            this.fileNameTxb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.readBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTxb
            // 
            this.inputTxb.Location = new System.Drawing.Point(38, 113);
            this.inputTxb.Multiline = true;
            this.inputTxb.Name = "inputTxb";
            this.inputTxb.Size = new System.Drawing.Size(201, 123);
            this.inputTxb.TabIndex = 0;
            this.inputTxb.TextChanged += new System.EventHandler(this.inputTxb_TextChanged);
            // 
            // fileNameTxb
            // 
            this.fileNameTxb.Location = new System.Drawing.Point(38, 281);
            this.fileNameTxb.Multiline = true;
            this.fileNameTxb.Name = "fileNameTxb";
            this.fileNameTxb.Size = new System.Drawing.Size(201, 24);
            this.fileNameTxb.TabIndex = 1;
            this.fileNameTxb.TextChanged += new System.EventHandler(this.fileNameTxb_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "写入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // readBtn
            // 
            this.readBtn.Location = new System.Drawing.Point(271, 279);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(75, 23);
            this.readBtn.TabIndex = 3;
            this.readBtn.Text = "读取";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // writeBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 438);
            this.Controls.Add(this.readBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fileNameTxb);
            this.Controls.Add(this.inputTxb);
            this.Name = "writeBtn";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTxb;
        private System.Windows.Forms.TextBox fileNameTxb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button readBtn;
    }
}

