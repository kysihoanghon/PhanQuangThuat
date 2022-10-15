namespace Calculator
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
            this.bt7 = new System.Windows.Forms.Button();
            this.bt_nhan = new System.Windows.Forms.Button();
            this.bt_cham = new System.Windows.Forms.Button();
            this.bt_cong = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt_tru = new System.Windows.Forms.Button();
            this.bt_chia = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt_CE = new System.Windows.Forms.Button();
            this.bt_result = new System.Windows.Forms.Button();
            this.bt_C = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.equation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt7
            // 
            this.bt7.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.Location = new System.Drawing.Point(16, 67);
            this.bt7.Margin = new System.Windows.Forms.Padding(5);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(45, 45);
            this.bt7.TabIndex = 0;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt_nhan
            // 
            this.bt_nhan.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_nhan.Location = new System.Drawing.Point(177, 122);
            this.bt_nhan.Margin = new System.Windows.Forms.Padding(5);
            this.bt_nhan.Name = "bt_nhan";
            this.bt_nhan.Size = new System.Drawing.Size(45, 45);
            this.bt_nhan.TabIndex = 1;
            this.bt_nhan.Text = "*";
            this.bt_nhan.UseVisualStyleBackColor = true;
            this.bt_nhan.Click += new System.EventHandler(this.operator_click);
            // 
            // bt_cham
            // 
            this.bt_cham.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cham.Location = new System.Drawing.Point(126, 233);
            this.bt_cham.Margin = new System.Windows.Forms.Padding(5);
            this.bt_cham.Name = "bt_cham";
            this.bt_cham.Size = new System.Drawing.Size(45, 45);
            this.bt_cham.TabIndex = 2;
            this.bt_cham.Text = ".";
            this.bt_cham.UseVisualStyleBackColor = true;
            this.bt_cham.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt_cong
            // 
            this.bt_cong.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cong.Location = new System.Drawing.Point(177, 233);
            this.bt_cong.Margin = new System.Windows.Forms.Padding(5);
            this.bt_cong.Name = "bt_cong";
            this.bt_cong.Size = new System.Drawing.Size(45, 45);
            this.bt_cong.TabIndex = 3;
            this.bt_cong.Text = "+";
            this.bt_cong.UseVisualStyleBackColor = true;
            this.bt_cong.Click += new System.EventHandler(this.operator_click);
            // 
            // bt3
            // 
            this.bt3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.Location = new System.Drawing.Point(126, 178);
            this.bt3.Margin = new System.Windows.Forms.Padding(5);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(45, 45);
            this.bt3.TabIndex = 4;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt6
            // 
            this.bt6.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.Location = new System.Drawing.Point(122, 122);
            this.bt6.Margin = new System.Windows.Forms.Padding(5);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(45, 45);
            this.bt6.TabIndex = 5;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt_tru
            // 
            this.bt_tru.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tru.Location = new System.Drawing.Point(177, 177);
            this.bt_tru.Margin = new System.Windows.Forms.Padding(5);
            this.bt_tru.Name = "bt_tru";
            this.bt_tru.Size = new System.Drawing.Size(45, 45);
            this.bt_tru.TabIndex = 6;
            this.bt_tru.Text = "-";
            this.bt_tru.UseVisualStyleBackColor = true;
            this.bt_tru.Click += new System.EventHandler(this.operator_click);
            // 
            // bt_chia
            // 
            this.bt_chia.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_chia.Location = new System.Drawing.Point(177, 67);
            this.bt_chia.Margin = new System.Windows.Forms.Padding(5);
            this.bt_chia.Name = "bt_chia";
            this.bt_chia.Size = new System.Drawing.Size(45, 45);
            this.bt_chia.TabIndex = 7;
            this.bt_chia.Text = "/";
            this.bt_chia.UseVisualStyleBackColor = true;
            this.bt_chia.Click += new System.EventHandler(this.operator_click);
            // 
            // bt9
            // 
            this.bt9.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.Location = new System.Drawing.Point(122, 67);
            this.bt9.Margin = new System.Windows.Forms.Padding(5);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(45, 45);
            this.bt9.TabIndex = 8;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt0
            // 
            this.bt0.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt0.Location = new System.Drawing.Point(16, 233);
            this.bt0.Margin = new System.Windows.Forms.Padding(5);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(100, 45);
            this.bt0.TabIndex = 9;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt2
            // 
            this.bt2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.Location = new System.Drawing.Point(71, 177);
            this.bt2.Margin = new System.Windows.Forms.Padding(5);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(45, 45);
            this.bt2.TabIndex = 10;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt5
            // 
            this.bt5.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.Location = new System.Drawing.Point(71, 122);
            this.bt5.Margin = new System.Windows.Forms.Padding(5);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(45, 45);
            this.bt5.TabIndex = 11;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt8
            // 
            this.bt8.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.Location = new System.Drawing.Point(71, 67);
            this.bt8.Margin = new System.Windows.Forms.Padding(5);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(45, 45);
            this.bt8.TabIndex = 12;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(16, 178);
            this.bt1.Margin = new System.Windows.Forms.Padding(5);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(45, 45);
            this.bt1.TabIndex = 13;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt4
            // 
            this.bt4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.Location = new System.Drawing.Point(16, 122);
            this.bt4.Margin = new System.Windows.Forms.Padding(5);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(45, 45);
            this.bt4.TabIndex = 14;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt_CE
            // 
            this.bt_CE.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CE.Location = new System.Drawing.Point(232, 67);
            this.bt_CE.Margin = new System.Windows.Forms.Padding(5);
            this.bt_CE.Name = "bt_CE";
            this.bt_CE.Size = new System.Drawing.Size(45, 45);
            this.bt_CE.TabIndex = 18;
            this.bt_CE.Text = "CE";
            this.bt_CE.UseVisualStyleBackColor = true;
            this.bt_CE.Click += new System.EventHandler(this.bt_CE_Click);
            // 
            // bt_result
            // 
            this.bt_result.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_result.Location = new System.Drawing.Point(232, 178);
            this.bt_result.Margin = new System.Windows.Forms.Padding(5);
            this.bt_result.Name = "bt_result";
            this.bt_result.Size = new System.Drawing.Size(45, 100);
            this.bt_result.TabIndex = 16;
            this.bt_result.Text = "=";
            this.bt_result.UseVisualStyleBackColor = true;
            this.bt_result.Click += new System.EventHandler(this.bt_result_Click);
            // 
            // bt_C
            // 
            this.bt_C.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_C.Location = new System.Drawing.Point(232, 122);
            this.bt_C.Margin = new System.Windows.Forms.Padding(5);
            this.bt_C.Name = "bt_C";
            this.bt_C.Size = new System.Drawing.Size(45, 45);
            this.bt_C.TabIndex = 15;
            this.bt_C.Text = "C";
            this.bt_C.UseVisualStyleBackColor = true;
            this.bt_C.Click += new System.EventHandler(this.bt_C_Click);
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(18, 12);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(261, 47);
            this.result.TabIndex = 19;
            this.result.Text = "0";
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // equation
            // 
            this.equation.AutoSize = true;
            this.equation.BackColor = System.Drawing.SystemColors.Window;
            this.equation.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equation.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.equation.Location = new System.Drawing.Point(23, 17);
            this.equation.Name = "equation";
            this.equation.Size = new System.Drawing.Size(0, 21);
            this.equation.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 302);
            this.Controls.Add(this.equation);
            this.Controls.Add(this.result);
            this.Controls.Add(this.bt_CE);
            this.Controls.Add(this.bt_result);
            this.Controls.Add(this.bt_C);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt_chia);
            this.Controls.Add(this.bt_tru);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt_cong);
            this.Controls.Add(this.bt_cham);
            this.Controls.Add(this.bt_nhan);
            this.Controls.Add(this.bt7);
            this.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Calculator";
            this.Click += new System.EventHandler(this.bt_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt_nhan;
        private System.Windows.Forms.Button bt_cham;
        private System.Windows.Forms.Button bt_cong;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt_tru;
        private System.Windows.Forms.Button bt_chia;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt_CE;
        private System.Windows.Forms.Button bt_result;
        private System.Windows.Forms.Button bt_C;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label equation;
    }
}

