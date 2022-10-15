namespace Art17
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
            this.lb_a = new System.Windows.Forms.ListBox();
            this.lb_b = new System.Windows.Forms.ListBox();
            this.bt_a_to_b = new System.Windows.Forms.Button();
            this.bt_b_to_a = new System.Windows.Forms.Button();
            this.bt_b_to_a_all = new System.Windows.Forms.Button();
            this.bt_a_to_b_all = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lb_a
            // 
            this.lb_a.FormattingEnabled = true;
            this.lb_a.ItemHeight = 16;
            this.lb_a.Items.AddRange(new object[] {
            "Giấc mơ Chapi",
            "Đôi mắt Pleiku",
            "Em muốn sống bên anh trọn đời",
            "H\'Zen lên rẫy",
            "Còn thương nhau về Buôn Ma Thuột",
            "Ly cà phê Ban Mê",
            "Đi tìm lời ru mặt trời"});
            this.lb_a.Location = new System.Drawing.Point(70, 57);
            this.lb_a.Name = "lb_a";
            this.lb_a.Size = new System.Drawing.Size(280, 308);
            this.lb_a.TabIndex = 0;
            
            // 
            // lb_b
            // 
            this.lb_b.FormattingEnabled = true;
            this.lb_b.ItemHeight = 16;
            this.lb_b.Location = new System.Drawing.Point(450, 57);
            this.lb_b.Name = "lb_b";
            this.lb_b.Size = new System.Drawing.Size(280, 308);
            this.lb_b.TabIndex = 1;
            // 
            // bt_a_to_b
            // 
            this.bt_a_to_b.Location = new System.Drawing.Point(374, 70);
            this.bt_a_to_b.Name = "bt_a_to_b";
            this.bt_a_to_b.Size = new System.Drawing.Size(50, 50);
            this.bt_a_to_b.TabIndex = 2;
            this.bt_a_to_b.Text = ">";
            this.bt_a_to_b.UseVisualStyleBackColor = true;
            this.bt_a_to_b.Click += new System.EventHandler(this.bt_a_to_b_Click);
            // 
            // bt_b_to_a
            // 
            this.bt_b_to_a.Location = new System.Drawing.Point(375, 217);
            this.bt_b_to_a.Name = "bt_b_to_a";
            this.bt_b_to_a.Size = new System.Drawing.Size(50, 50);
            this.bt_b_to_a.TabIndex = 3;
            this.bt_b_to_a.Text = "<";
            this.bt_b_to_a.UseVisualStyleBackColor = true;
            this.bt_b_to_a.Click += new System.EventHandler(this.bt_b_to_a_Click);
            // 
            // bt_b_to_a_all
            // 
            this.bt_b_to_a_all.Location = new System.Drawing.Point(375, 283);
            this.bt_b_to_a_all.Name = "bt_b_to_a_all";
            this.bt_b_to_a_all.Size = new System.Drawing.Size(50, 50);
            this.bt_b_to_a_all.TabIndex = 4;
            this.bt_b_to_a_all.Text = "<<";
            this.bt_b_to_a_all.UseVisualStyleBackColor = true;
            // 
            // bt_a_to_b_all
            // 
            this.bt_a_to_b_all.Location = new System.Drawing.Point(374, 144);
            this.bt_a_to_b_all.Name = "bt_a_to_b_all";
            this.bt_a_to_b_all.Size = new System.Drawing.Size(50, 50);
            this.bt_a_to_b_all.TabIndex = 5;
            this.bt_a_to_b_all.Text = ">>";
            this.bt_a_to_b_all.UseVisualStyleBackColor = true;
            this.bt_a_to_b_all.Click += new System.EventHandler(this.bt_a_to_b_all_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(52, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 354);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách bài hát";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(430, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 354);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách bài hát ưu thích";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_a_to_b_all);
            this.Controls.Add(this.bt_b_to_a_all);
            this.Controls.Add(this.bt_b_to_a);
            this.Controls.Add(this.bt_a_to_b);
            this.Controls.Add(this.lb_b);
            this.Controls.Add(this.lb_a);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_a;
        private System.Windows.Forms.ListBox lb_b;
        private System.Windows.Forms.Button bt_a_to_b;
        private System.Windows.Forms.Button bt_b_to_a;
        private System.Windows.Forms.Button bt_b_to_a_all;
        private System.Windows.Forms.Button bt_a_to_b_all;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

