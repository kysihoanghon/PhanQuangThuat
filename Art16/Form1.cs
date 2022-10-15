using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Art16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            string item = cb_khoa.SelectedItem.ToString();
            string msg = null;
           
            if (rb_nam.Checked == true)
                msg += "Nam ";
            if (rb_nu.Checked == true)
                msg += "Nữ ";
            else msg += "Unknow";
            string kq = tb_name.Text+ Environment.NewLine + "-Giới tính: " + msg + Environment.NewLine + "-Ngày sinh: " + dp_ngaysinh.Text + Environment.NewLine + "-Khoa: " + item + Environment.NewLine;
            tb_result.Text += kq;   
        }

       
        
        
        
        
        
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void cb_khoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
