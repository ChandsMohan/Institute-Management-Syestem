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
    public partial class frmstart : Form
    {
        public frmstart()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int i = 0;
            for (i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
            }
            timer1.Enabled = false;
            frmadminlogin f = new frmadminlogin();
            this.Visible = false;
            f.Show();
        }
    }
}
