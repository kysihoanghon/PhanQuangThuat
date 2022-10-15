namespace Art16
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
            this.tb_name = new System.Windows.Forms.TextBox();
            this.cb_khoa = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_nam = new System.Windows.Forms.RadioButton();
            this.rb_nu = new System.Windows.Forms.RadioButton();
            this.dp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.tb_result = new System.Windows.Forms.RichTextBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(119, 45);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(280, 30);
            this.tb_name.TabIndex = 0;
            // 
            // cb_khoa
            // 
            this.cb_khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_khoa.FormattingEnabled = true;
            this.cb_khoa.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Cơ khí"});
            this.cb_khoa.Location = new System.Drawing.Point(119, 219);
            this.cb_khoa.Name = "cb_khoa";
            this.cb_khoa.Size = new System.Drawing.Size(280, 33);
            this.cb_khoa.TabIndex = 1;
            this.cb_khoa.Text = "Công nghệ thông tin";
            this.cb_khoa.SelectedIndexChanged += new System.EventHandler(this.cb_khoa_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_nu);
            this.groupBox1.Controls.Add(this.rb_nam);
            this.groupBox1.Location = new System.Drawing.Point(119, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";
            // 
            // rb_nam
            // 
            this.rb_nam.AutoSize = true;
            this.rb_nam.Location = new System.Drawing.Point(79, 22);
            this.rb_nam.Name = "rb_nam";
            this.rb_nam.Size = new System.Drawing.Size(57, 20);
            this.rb_nam.TabIndex = 0;
            this.rb_nam.TabStop = true;
            this.rb_nam.Text = "Nam";
            this.rb_nam.UseVisualStyleBackColor = true;
            // 
            // rb_nu
            // 
            this.rb_nu.AutoSize = true;
            this.rb_nu.Location = new System.Drawing.Point(188, 22);
            this.rb_nu.Name = "rb_nu";
            this.rb_nu.Size = new System.Drawing.Size(45, 20);
            this.rb_nu.TabIndex = 1;
            this.rb_nu.TabStop = true;
            this.rb_nu.Text = "Nữ";
            this.rb_nu.UseVisualStyleBackColor = true;
            // 
            // dp_ngaysinh
            // 
            this.dp_ngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dp_ngaysinh.Location = new System.Drawing.Point(119, 95);
            this.dp_ngaysinh.Name = "dp_ngaysinh";
            this.dp_ngaysinh.Size = new System.Drawing.Size(280, 28);
            this.dp_ngaysinh.TabIndex = 3;
            // 
            // tb_result
            // 
            this.tb_result.Location = new System.Drawing.Point(119, 258);
            this.tb_result.Name = "tb_result";
            this.tb_result.Size = new System.Drawing.Size(280, 131);
            this.tb_result.TabIndex = 4;
            this.tb_result.Text = "";
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(224, 409);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(75, 23);
            this.bt_add.TabIndex = 5;
            this.bt_add.Text = "Thêm";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(324, 409);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(75, 23);
            this.bt_exit.TabIndex = 6;
            this.bt_exit.Text = "Thoát";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Họ và tên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Khoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Trạng thái";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.dp_ngaysinh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cb_khoa);
            this.Controls.Add(this.tb_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.ComboBox cb_khoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_nu;
        private System.Windows.Forms.RadioButton rb_nam;
        private System.Windows.Forms.DateTimePicker dp_ngaysinh;
        private System.Windows.Forms.RichTextBox tb_result;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

