using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Institute_Management_System
{
    public partial class frmupdatecourse : Form
    {
        DBConnect con = new DBConnect();
        public frmupdatecourse()
        {
            InitializeComponent();
        }

        private void btnvalidate_Click(object sender, EventArgs e)
        {
            if (btnvalidate.Text == "Validate")
                try
                {
                    con.OpenConnection();
                    string query = "select * from tbl_courseinfo where CourseID='" + txtcourseid.Text.ToUpper() + "'";
                    SqlCommand cmd = new SqlCommand(query, DBConnect.connection);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            btnvalidate.Text = "Cancel";
                            lblreason1.Text = "";
                            txtcourseid.ReadOnly = true;
                            gbsecondstep.Visible = true;
                            txtcoursename.Text = dr.GetValue(1).ToString();
                            txtcourseduration.Text = dr.GetValue(2).ToString();
                            txtcoursefees.Text = dr.GetValue(3).ToString();
                            txtfirstinstallment.Text = dr.GetValue(4).ToString();
                            txtsecondinstalment.Text = dr.GetValue(5).ToString();
                        }
                    }
                    else
                    {
                        lblreason1.Text = "CourseID you Entered Is Incorrect \n Please Enter Correct CourseID";
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.CloseConnection();
                }
            else
            {
                txtcourseid.Text = "";
                gbsecondstep.Visible = false;
                btnvalidate.Text = "Validate";
            }
        }

        private void frmupdatecourse_Load(object sender, EventArgs e)
        {
            gbsecondstep.Visible = false;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt64(txtcoursefees.Text)) == ((Convert.ToInt64(txtfirstinstallment.Text)) + (Convert.ToInt64(txtsecondinstalment.Text))))
            {
                try
                {
                    con.OpenConnection();
                    string query = "update tbl_courseinfo set CourseName='" + txtcoursename.Text + "', CourseDurations='" + txtcourseduration.Text + "', CourseFees='" + txtcoursefees.Text + "', Firstinstallment='" + txtfirstinstallment.Text + "', Secondinstallment='" + txtsecondinstalment.Text + "' where CourseID='" + txtcourseid.Text.ToUpper() + "'";
                    SqlCommand cmd = new SqlCommand(query, DBConnect.connection);
                    int res = cmd.ExecuteNonQuery();
                    if (res == 1)
                    {
                        MessageBox.Show("Updation Is Successfull");
                        gbsecondstep.Visible = false;
                        txtcourseid.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("An Error Occur During Updation");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("Sum Of First Installment And Second Installment Must Be Equal To Course Fees");
            }
        }

        private void txtcoursename_Leave(object sender, EventArgs e)
        {
            if (txtcoursename.Text.Trim().Length.Equals(0))
            {
                lblreason2.Text = "Please Course Name Can't Be Empty";
                txtcoursename.Focus();
            }
            else
            {
                lblreason2.Text = "";
            }
        }

        private void txtcourseduration_Leave(object sender, EventArgs e)
        {
            if (txtcourseduration.Text.Trim().Length.Equals(0))
            {
                lblreason2.Text = "Please Course Duration Can't Be Empty";
                txtcourseduration.Focus();
            }
            else
            {
                lblreason2.Text = "";
            }
        }

        private void txtcoursefees_Leave(object sender, EventArgs e)
        {
            if (txtcoursefees.Text.Trim().Length.Equals(0))
            {
                lblreason2.Text = "Please Course Fees Can't Be Empty";
                txtcoursefees.Focus();
            }
            else
            {
                lblreason2.Text = "";
            }
        }

        private void txtfirstinstallment_Leave(object sender, EventArgs e)
        {
            if (txtfirstinstallment.Text.Trim().Length.Equals(0))
            {
                lblreason2.Text = "Please First Installment Can't Be Empty";
                txtfirstinstallment.Focus();
            }
            else
            {
                lblreason2.Text = "";
            }
        }

        private void txtsecondinstalment_Leave(object sender, EventArgs e)
        {
            if (txtsecondinstalment.Text.Trim().Length.Equals(0))
            {
                lblreason2.Text = "Please Second Installment Can't Be Empty";
                txtsecondinstalment.Focus();
            }
            else
            {
                lblreason2.Text = "";
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

        private void txtsecondinstalment_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
