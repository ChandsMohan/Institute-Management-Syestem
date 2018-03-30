using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Institute_Management_System
{
    public partial class frmaddnewcourse : Form
    {
        DBConnect con = new DBConnect();
        bool boolian = false;
        public frmaddnewcourse()
        {
            InitializeComponent();
        }

        private void frmaddnewcourse_Load(object sender, EventArgs e)
        {
            txtcourseID.Text = GetUniqueCourseID();
            txtcourseID.Focus();
        }

        public string GetUniqueCourseID()
        {
            int coursecount = 0;
            string courseid = "";
            try
            {
                con.OpenConnection();
                string str = "select (MAX(SUBSTRING(CourseID,7,3))) from tbl_courseinfo";
                SqlCommand cmd = new SqlCommand(str, DBConnect.connection);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (!(dr.GetValue(0).ToString() == ""))
                        {
                            coursecount = Convert.ToInt32(dr.GetString(0));
                            int courseinc = coursecount + 1;
                            if (coursecount <= 9)
                            {
                                courseid = "COURSE00" + courseinc;
                            }
                            else
                            {
                                courseid = "COURSE0" + courseinc;
                            }
                        }
                        else
                        {
                            courseid = "COURSE001";
                        }
                    }
                }
                else
                {
                    courseid = "COURSE001";
                }
                txtcourseID.ReadOnly = true;
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.CloseConnection();
            }
            return courseid;

        }

        private void frmaddnewcourse_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do You Want to Exit", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void txtcoursename_Leave(object sender, EventArgs e)
        {
            if (txtcoursename.Text.Trim().Length.Equals(0))
            {
                lblreason1.ForeColor = Color.Red;
                lblreason1.Text = "Please Enter Course Name First";
                txtcoursename.Focus();
            }
        }

        private void txtcourseduration_Leave(object sender, EventArgs e)
        {
            if (txtcourseduration.Text.Trim().Length.Equals(0))
            {
                lblreason1.ForeColor = Color.Red;
                lblreason1.Text = "Please Enter Course Duration";
                txtcourseduration.Focus();
            }
            else
            {
                lblreason1.Text = "";
            }
        }

        private void txtcoursefees_Leave(object sender, EventArgs e)
        {
            if (txtcoursefees.Text.Trim().Length.Equals(0))
            {
                lblreason2.ForeColor = Color.Red;
                lblreason2.Text = "Please Enter Course Fees";
                txtcoursefees.Focus();
            }
            else
            {

            }
        }

        private void txtcoursefees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((((int)e.KeyChar < 48) || ((int)e.KeyChar > 57)) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Enter Numbers Only");
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtfirstinstallment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((((int)e.KeyChar < 48) || ((int)e.KeyChar > 57)) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Enter Numbers Only");
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtsecondinstallment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((((int)e.KeyChar < 48) || ((int)e.KeyChar > 57)) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("Enter Numbers Only");
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtfirstinstallment_Leave(object sender, EventArgs e)
        {
            if (txtfirstinstallment.Text.Trim().Length.Equals(0))
            {
                lblreason2.ForeColor = Color.Red;
                lblreason2.Text = "Please Enter First Installment";
                txtfirstinstallment.Focus();
            }
        }

        private void txtsecondinstallment_Leave(object sender, EventArgs e)
        {
            if (txtsecondinstallment.Text.Trim().Length.Equals(0))
            {
                lblreason2.ForeColor = Color.Red;
                lblreason2.Text = "Please Enter First Installment";
                txtsecondinstallment.Focus();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            boolian = CourseFees();
            if (boolian)
            {
                try
                {
                    con.OpenConnection();
                    string query = "insert into tbl_courseinfo values('" + txtcourseID.Text + "','" + txtcoursename.Text + "','" + txtcourseduration.Text + "','" + txtcoursefees.Text + "','" + txtfirstinstallment.Text + "','" + txtsecondinstallment.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, DBConnect.connection);
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Data Saved Succesfully");
                        txtcoursename.Clear();
                        txtcourseduration.Clear();
                        txtcoursefees.Clear();
                        txtcourseID.Clear();
                        txtfirstinstallment.Clear();
                        txtsecondinstallment.Clear();
                    }
                    else
                    {
                        MessageBox.Show("An Error Occur During Inserting Values");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.CloseConnection();
                    frmaddnewcourse_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Sum of FirstInstallment And Second Installment Must Be Equal to Course Fees");
            }
        }

        public bool CourseFees()
        {
            bool b = false;
            if ((Convert.ToInt32(txtcoursefees.Text))!= ((Convert.ToInt32(txtfirstinstallment.Text))+ (Convert.ToInt32(txtsecondinstallment.Text))))
            {
                MessageBox.Show("Course Fees Must Be Equal to Sum of FirstInstallment And Second Installment");
                return b;
            }
            else
            {
                b = true;
                return b;
            }
        }
    }
}
