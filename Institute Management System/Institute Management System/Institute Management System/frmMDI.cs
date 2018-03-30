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
    public partial class frmMDIMaster : Form
    {
        public frmMDIMaster()
        {
            InitializeComponent();
        }

        private bool CheckForDuplicationForm(Form newForm)
        {
            bool b = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == newForm.GetType())
                {
                    frm.Activate();
                    b = true;
                }
            }
            return b;
        }

        private void studentRegistrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmStudentregister obj = new frmStudentregister();
            bool frmpresent = CheckForDuplicationForm(obj);
            if (frmpresent)
                return;
            else if(!frmpresent)
            {
                obj.MdiParent= this;
                obj.Show();
            }
            
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            frmadminlogin obj = new frmadminlogin();
            obj.Dispose();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want to Logout?", "Logout", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                frmadminlogin obj = new frmadminlogin();
                obj.LoginDetails(frmadminlogin.AdminID, "Logout");
                obj.Show();
                this.Dispose();
            }
            else
            {
                
            }
        }

        private void frmMDIMaster_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do You Want to Exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                frmadminlogin obj = new frmadminlogin();
                obj.LoginDetails(frmadminlogin.AdminID, "Logout");
                obj.Show();
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void updateCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmaddnewcourse obj = new frmaddnewcourse();
            bool frmpresent = CheckForDuplicationForm(obj);
            if (frmpresent)
                return;
            else if (!frmpresent)
            {
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void studentsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentReport obj = new frmStudentReport();
            bool frmpresent = CheckForDuplicationForm(obj);
            if (frmpresent)
                return;
            else if (!frmpresent)
            {
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void firstInstallmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmfirstinstalfees obj = new frmfirstinstalfees();
            bool frmpresent = CheckForDuplicationForm(obj);
            if (frmpresent)
                return;
            else if (!frmpresent)
            {
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void secondInstallmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsecondinstallment obj = new frmsecondinstallment();
            bool frmpresent = CheckForDuplicationForm(obj);
            if (frmpresent)
                return;
            else if(!frmpresent)
            {
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void updateCourseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmupdatecourse obj = new frmupdatecourse();
            bool frmpresent = CheckForDuplicationForm(obj);
            if (frmpresent)
                return;
            else if (!frmpresent)
            {
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void courseDetailsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmcoursedetails obj = new frmcoursedetails();
            bool frmpresent = CheckForDuplicationForm(obj);
            if (frmpresent)
                return;
            else if (!frmpresent)
            {
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void StudentsFeesRecordsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmstudentfeedetails obj = new frmstudentfeedetails();
            bool frmpresent = CheckForDuplicationForm(obj);
            if (frmpresent)
                return;
            else if (!frmpresent)
            {
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void collectFeesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
