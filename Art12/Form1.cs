using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Art12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_chonkhoa.SelectedIndex = 2;
        }

        private void cb_chonkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cb_chonkhoa.SelectedIndex;
            tb_result.Text = "Bạn đã chọn khoa thứ: " + index.ToString();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            string item = cb_chonkhoa.SelectedItem.ToString();
            tb_result.Text = "Bạn là sinh viên khoa: " + item;
        }
    }
}
