namespace Art9
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
            this.tb_x = new System.Windows.Forms.TextBox();
            this.tb_y = new System.Windows.Forms.TextBox();
            this.tb_kq = new System.Windows.Forms.RichTextBox();
            this.bt_luu = new System.Windows.Forms.Button();
            this.bt_cong = new System.Windows.Forms.Button();
            this.bt_nhan = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_x
            // 
            this.tb_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_x.Location = new System.Drawing.Point(93, 59);
            this.tb_x.Name = "tb_x";
            this.tb_x.Size = new System.Drawing.Size(579, 30);
            this.tb_x.TabIndex = 0;
            // 
            // tb_y
            // 
            this.tb_y.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_y.Location = new System.Drawing.Point(93, 116);
            this.tb_y.Name = "tb_y";
            this.tb_y.Size = new System.Drawing.Size(579, 30);
            this.tb_y.TabIndex = 1;
            // 
            // tb_kq
            // 
            this.tb_kq.Location = new System.Drawing.Point(93, 179);
            this.tb_kq.Name = "tb_kq";
            this.tb_kq.Size = new System.Drawing.Size(579, 203);
            this.tb_kq.TabIndex = 2;
            this.tb_kq.Text = "";
            // 
            // bt_luu
            // 
            this.bt_luu.BackColor = System.Drawing.SystemColors.Control;
            this.bt_luu.Location = new System.Drawing.Point(33, 415);
            this.bt_luu.Name = "bt_luu";
            this.bt_luu.Size = new System.Drawing.Size(75, 23);
            this.bt_luu.TabIndex = 3;
            this.bt_luu.Text = "Lưu";
            this.bt_luu.UseVisualStyleBackColor = false;
            // 
            // bt_cong
            // 
            this.bt_cong.BackColor = System.Drawing.SystemColors.Control;
            this.bt_cong.Location = new System.Drawing.Point(401, 415);
            this.bt_cong.Name = "bt_cong";
            this.bt_cong.Size = new System.Drawing.Size(75, 23);
            this.bt_cong.TabIndex = 4;
            this.bt_cong.Text = "Cộng";
            this.bt_cong.UseVisualStyleBackColor = false;
            this.bt_cong.Click += new System.EventHandler(this.bt_cong_Click);
            // 
            // bt_nhan
            // 
            this.bt_nhan.BackColor = System.Drawing.SystemColors.Control;
            this.bt_nhan.Location = new System.Drawing.Point(496, 415);
            this.bt_nhan.Name = "bt_nhan";
            this.bt_nhan.Size = new System.Drawing.Size(75, 23);
            this.bt_nhan.TabIndex = 5;
            this.bt_nhan.Text = "Nhân";
            this.bt_nhan.UseVisualStyleBackColor = false;
            this.bt_nhan.Click += new System.EventHandler(this.bt_nhan_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.BackColor = System.Drawing.SystemColors.Control;
            this.bt_exit.Location = new System.Drawing.Point(588, 415);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(75, 23);
            this.bt_exit.TabIndex = 6;
            this.bt_exit.Text = "Thoát";
            this.bt_exit.UseVisualStyleBackColor = false;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Số X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Số Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kết quả";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_nhan);
            this.Controls.Add(this.bt_cong);
            this.Controls.Add(this.bt_luu);
            this.Controls.Add(this.tb_kq);
            this.Controls.Add(this.tb_y);
            this.Controls.Add(this.tb_x);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_x;
        private System.Windows.Forms.TextBox tb_y;
        private System.Windows.Forms.RichTextBox tb_kq;
        private System.Windows.Forms.Button bt_luu;
        private System.Windows.Forms.Button bt_cong;
        private System.Windows.Forms.Button bt_nhan;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

