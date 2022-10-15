using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giam_gia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btRun_Click(object sender, EventArgs e)
        {
            string msg = null;
            int disc = 0;
            if (rbNam.Checked == true)
                msg += "Ông ";
            if (rbNu.Checked == true)
                msg += "Bà ";
            if (ckDiscount.Checked == true)
                disc = 5 ;
            tbResult.Text = msg + tbName.Text + " được giảm " + disc.ToString() + " % " + "\r\n";
        }


        private void ckDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDiscount.Checked == true)
                tbDiscount.Enabled = true;
            else
                tbDiscount.Enabled = false; 
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
