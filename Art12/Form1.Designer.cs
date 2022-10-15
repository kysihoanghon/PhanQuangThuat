namespace Art12
{
    partial class Form1
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
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_ok = new System.Windows.Forms.Button();
            this.cb_chonkhoa = new System.Windows.Forms.ComboBox();
            this.tb_result = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // bt_clear
            // 
            this.bt_clear.Location = new System.Drawing.Point(179, 306);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(75, 23);
            this.bt_clear.TabIndex = 0;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = true;
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(260, 306);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 1;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // cb_chonkhoa
            // 
            this.cb_chonkhoa.FormattingEnabled = true;
            this.cb_chonkhoa.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Ngoại ngữ",
            "Quản trị kinh doanh",
            "Cơ khí",
            "Điện",
            "Cơ khí động lực"});
            this.cb_chonkhoa.Location = new System.Drawing.Point(36, 41);
            this.cb_chonkhoa.Name = "cb_chonkhoa";
            this.cb_chonkhoa.Size = new System.Drawing.Size(299, 24);
            this.cb_chonkhoa.TabIndex = 2;
            this.cb_chonkhoa.Text = "Công nghệ thông tin";
            this.cb_chonkhoa.SelectedIndexChanged += new System.EventHandler(this.cb_chonkhoa_SelectedIndexChanged);
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(36, 81);
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(299, 204);
            this.tb_result.TabIndex = 3;
            this.tb_result.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 353);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.cb_chonkhoa);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.bt_clear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.ComboBox cb_chonkhoa;
        private System.Windows.Forms.RichTextBox tb_result;
    }
}

