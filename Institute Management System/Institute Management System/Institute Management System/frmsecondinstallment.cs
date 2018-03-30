using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Institute_Management_System
{
    public partial class frmsecondinstallment : Form
    {
        DBConnect con = new DBConnect();
        public frmsecondinstallment()
        {
            InitializeComponent();
        }

        private void btnvalidate_Click(object sender, EventArgs e)
        {
            if (btnvalidate.Text == "Validate")
                try
                {
                    con.OpenConnection();
                    string query = "select Name,CourseEnroll,Course_Durations,Course_Fees,Secondinstallment,Firstinstallmentstatus,Secondinstallmentstatus from tbl_registration where Registration_Id='" + txtregid.Text.ToUpper() + "'";
                    SqlCommand cmd = new SqlCommand(query, DBConnect.connection);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            lblreason1.Text = "";
                            btnvalidate.Text = "Cancel";
                            gbsecondstep.Visible = true;
                            txtregid.ReadOnly = true;
                            txtstuname.Text = dr.GetValue(0).ToString();
                            txtcourseenroll.Text = dr.GetValue(1).ToString();
                            txtcourseduration.Text = dr.GetValue(2).ToString();
                            txtcoursefee.Text = dr.GetValue(3).ToString();
                            txtsecondinstalment.Text = dr.GetValue(4).ToString();
                            if (dr.GetValue(5).ToString() == "Not Paid")
                            {
                                MessageBox.Show("Please Pay FirstInstallment First");
                                this.Dispose();
                            }
                            if (dr.GetValue(6).ToString() == "Paid")
                            {
                                lblreason2.Text = "Already Paid,Click Print Slip for Print Slip";
                                btnpay.Text = "Print Slip";
                            }
                        }
                    }
                    else
                    {
                        lblreason1.Text = "RegistrationID you entered does not exixts\n Please Enter valid RegistrationID";
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
                gbsecondstep.Visible = false;
                txtregid.Text = "";
                btnvalidate.Text = "Validate";
            }
        }

        private void frmsecondinstallment_Load(object sender, EventArgs e)
        {
            gbsecondstep.Visible = false;
        }

        private void btnpay_Click(object sender, EventArgs e)
        {

            try
            {
                if (btnpay.Text == "Pay Now")
                {
                    con.OpenConnection();
                    string query1 = "update tbl_registration set Secondinstallmentstatus='Paid' where Registration_Id='" + txtregid.Text.ToUpper() + "'";
                    SqlCommand cmd = new SqlCommand(query1, DBConnect.connection);
                    int res = cmd.ExecuteNonQuery();
                    if (res == 1)
                    {
                        MessageBox.Show("Payment Has Been Successfull");
                        PrintSlip();
                    }
                }
                else
                {
                    PrintSlip();
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

        public void PrintSlip()
        {
            frmprintslip obj = new frmprintslip();
            obj.lblregid.Text = txtregid.Text.ToUpper();
            obj.lblstuname.Text = txtstuname.Text;
            obj.lblcourseenroll.Text = txtcourseenroll.Text;
            obj.lblcourseduration.Text = txtcourseduration.Text;
            obj.lblcoursefee.Text = txtcoursefee.Text;
            obj.lbl_installment.Text = txtsecondinstalment.Text;
            obj.lblfirstpay.Text = "Second Installment";
            obj.Show();
            this.Hide();
        }

        private void frmsecondinstallment_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
