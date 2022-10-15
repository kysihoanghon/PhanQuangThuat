using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Art17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_a_to_b_Click(object sender, EventArgs e)
        {
            string song= lb_a.SelectedItem.ToString(); 
            lb_b.Items.Add(song);
            lb_a.Items.RemoveAt(lb_a.SelectedIndex);
        }

        private void bt_b_to_a_Click(object sender, EventArgs e)
        {
            string song = lb_b.SelectedItem.ToString();
            lb_a.Items.Add(song);
            lb_b.Items.RemoveAt(lb_b.SelectedIndex);
        }
       
       

       

        private void lb_a_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lb_a.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string song = lb_a.Items[index].ToString();
                lb_b.Items.Add(song);
                lb_a.Items.RemoveAt(lb_a.SelectedIndex);
            }
        }
        private void bt_a_to_b_all_Click(object sender, EventArgs e)
        {
            for (int i = lb_a.Items.Count; i >= 0; i--)
            {

            }

        }
    }
}
