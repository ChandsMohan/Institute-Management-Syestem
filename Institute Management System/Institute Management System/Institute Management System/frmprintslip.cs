using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Institute_Management_System
{
    public partial class frmprintslip : Form
    {
        public frmprintslip()
        {
            InitializeComponent();
        }

        private void frmprintslip_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do You Want To Exit", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            PrintDialog pd1 = new PrintDialog();
            pd1.ShowDialog();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
