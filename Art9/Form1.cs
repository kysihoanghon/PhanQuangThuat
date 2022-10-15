using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Art9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_cong_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(tb_x.Text);
            double txt2 = Convert.ToDouble(tb_y.Text);

            double sum = txt1 + txt2;

            tb_kq.Text = sum.ToString();

        }

        private void bt_nhan_Click(object sender, EventArgs e)
        {
            double txt1 = Convert.ToDouble(tb_x.Text);
            double txt2 = Convert.ToDouble(tb_y.Text);

            double sum = txt1 * txt2;

            tb_kq.Text = sum.ToString();
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
