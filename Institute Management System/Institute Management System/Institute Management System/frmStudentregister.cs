using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;

namespace Institute_Management_System
{
    public partial class frmStudentregister : Form
    {
        DBConnect con = new DBConnect();
        public static string gender;
        bool GenderID = false;
        string qualification;
        public frmStudentregister()
        {
            InitializeComponent();
        }

        private void frmStudentregister_Load(object sender, EventArgs e)
        {
            txtregid.Text = getuniqueID();
            txtregid.Focus();
            CourseInfo();
            lblreason2.Text = "";
        }

        private string getuniqueID()
        {
                con.OpenConnection();
                int regcount = -1;
                string strregister = "";
                string str = "select (MAX(SUBSTRING(Registration_Id,7,3))) from tbl_registration";
                SqlCommand cmd = new SqlCommand(str, DBConnect.connection);
                SqlDataReader dr = null;
                try
                {
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            if (!(dr.GetValue(0).ToString() == ""))
                            {
                                regcount = Convert.ToInt32(dr.GetString(0));
                                int regcountinc = regcount + 1;
                                if (regcountinc <= 9)
                                {
                                    strregister = "STUREG00" + regcountinc;
                                }
                                else
                                {
                                    strregister = "STUREG0" + regcountinc;
                                }
                            }
                            else
                            {
                                strregister = "STUREG001";
                            }
                        }
                    }
                    else
                    {
                        strregister = "STUREG001";
                    }
                    txtregid.ReadOnly = true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.CloseConnection();
                }
                return strregister;
 }

        private void CourseInfo()
        {
            try
            {
                con.OpenConnection();
                string str = "select CourseName from tbl_CourseInfo";
                SqlDataAdapter sda = new SqlDataAdapter(str, DBConnect.connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataRow row = dt.NewRow();
                row["CourseName"] = "Select CourseName";
                dt.Rows.InsertAt(row, 0);
                CBCourseEnroll.DataSource = dt;
                CBCourseEnroll.DisplayMember = "CourseName";
                CBCourseEnroll.ValueMember = "CourseName";

                //SqlCommand cmd = new SqlCommand(str, DBConnect.connection);
                //SqlDataReader dr = cmd.ExecuteReader();
                //comboBox2.Items.Add("Select CourseName");
                //comboBox2.SelectedText = "Select CourseName";
                //if (dr.HasRows)
                //{
                //    while (dr.Read())
                //    {
                //        comboBox2.Items.Add(dr.GetString(0));
                //    }
                //}
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

        public bool GenderSelect()
        {
            bool b = false;
            if (radioButton1.Checked == true)
            {
                gender = radioButton1.Text;
                b = true;
            }
            else if (radioButton2.Checked == true)
            {
                gender = radioButton2.Text;
                b = true;
            }
            else
            {
                MessageBox.Show("Please Select Gender");
                b =false;
            }
            return b;
        }

        private void txtstuname_Leave(object sender, EventArgs e)
        {
            if (txtstuname.Text.Trim().Length.Equals(0))
            {
                lblreason1.ForeColor = Color.Red;
                lblreason1.Text = "Please Enter Student Name First";
                txtstuname.Focus();
            }
            else
            {
                lblreason1.Text = "";
            }
        }

        private void txtaddress_Leave(object sender, EventArgs e)
        {
            if (txtaddress.Text.Trim().Length.Equals(0))
            {
                lblreason1.ForeColor = Color.Red;
                lblreason1.Text = "Please Enter Adress First";
                txtaddress.Focus();
            }
            else
            {
                lblreason1.Text = "";
            }
        }

        private void txtcontactno_Leave(object sender, EventArgs e)
        {
            if (txtcontactno.Text.Trim().Length.Equals(0))
            {
                lblreason1.ForeColor = Color.Red;
                lblreason1.Text = "Please Enter Contact no First";
                txtcontactno.Focus();
            }
            else if (txtcontactno.Text.Trim().Length < 10)
            {
                lblreason1.ForeColor = Color.Red;
                lblreason1.Text = "Please Enter Correct Contact no";
                txtcontactno.Focus();
            }
            else
            {
                lblreason1.Text = "";
            }

        }

        private void txtcontactno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((((int)e.KeyChar < 48) || ((int)e.KeyChar > 57)) && ((int)e.KeyChar != 8))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Correct Number,Give Only Number");
            }
            else
            {
                e.Handled = false;

            }
        }

        private void frmStudentregister_FormClosing(object sender, FormClosingEventArgs e)
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

        private void txtqualification_Leave(object sender, EventArgs e)
        {
            if (txtqualification.Visible == true && txtqualification.Text.Trim().Length.Equals(0))
            {
                lblreason2.ForeColor = Color.Red;
                lblreason2.Text = "Please Provide Your Qualification";
                txtqualification.Focus();
            }
            else
            {
                qualification= CBqualificatin.Text + ',' + txtqualification.Text;
                lblreason2.Text = "";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBqualificatin.Text == "Other")
            {
                txtqualification.Visible = true;
            }
            else
            {
                txtqualification.Visible = false;
                txtqualification.Clear();
                qualification = CBqualificatin.Text;
            }
            if (CBqualificatin.Text == "Select Qualification")
            {
                lblreason2.ForeColor = Color.Red;
                lblreason2.Text = "Select Qualification First";
                qualification = "";
                CBqualificatin.Focus();
            }
            else
            {
                lblreason2.Text = "";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBCourseEnroll.Text == "Select CourseName")
            {
                lblreason2.ForeColor = Color.Red;
                lblreason2.Text = "Please Select CourseName First";
                CBCourseEnroll.Focus();
            }
            else
            {
                lblreason2.Text = "";
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                gender = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                gender = radioButton2.Text;
            }
            else
            {
                MessageBox.Show("Please Select Gender");
            }

        }

        private void btnregister_Click_1(object sender, EventArgs e)
        {
            GenderID = GenderSelect();
            if (GenderID)
            {
                if (CBqualificatin.Text != "Select Qualification")
                {
                    if (CBCourseEnroll.Text != "Select CourseName")
                    {

                        con.OpenConnection();
                        string query = "insert into tbl_registration(Registration_Id,Name,Address,Contact_No,DOB,Gender,Qualification,CourseEnroll,Registration_fee) values('" + txtregid.Text + "','" + txtstuname.Text + "','" + txtaddress.Text + "','" + txtcontactno.Text + "','" + dateTimePicker1.Text + "','" + gender + "','" + qualification + "','" + CBCourseEnroll.Text + "','" + txtregfee.Text + "')";
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = query;
                        cmd.Connection = DBConnect.connection;
                        int res = cmd.ExecuteNonQuery();
                        string query1 = "select CourseName,CourseDurations,CourseFees,Firstinstallment,Secondinstallment from tbl_courseinfo where CourseName='" + CBCourseEnroll.Text + "'";
                        SqlDataAdapter ada = new SqlDataAdapter(query1, DBConnect.connection);
                        DataTable dt = new DataTable();
                        ada.Fill(dt);
                        string query2 = "update tbl_registration set Course_Durations='" + dt.Rows[0]["CourseDurations"].ToString() + "',Course_Fees=" + Convert.ToInt64(dt.Rows[0]["CourseFees"].ToString()) + ", Firstinstallment=" + Convert.ToInt64(dt.Rows[0]["Firstinstallment"].ToString()) + ",Firstinstallmentstatus='Not Paid',SecondInstallment=" + Convert.ToInt64(dt.Rows[0]["SecondInstallment"].ToString()) + ",Secondinstallmentstatus='Not Paid' where CourseEnroll='" + dt.Rows[0]["CourseName"].ToString() + "'and Registration_Id='" + txtregid.Text + "'";
                        SqlCommand cmd1 = new SqlCommand(query2, DBConnect.connection);
                        cmd1.CommandText = query2;
                        cmd1.Connection = DBConnect.connection;
                        int res1 = cmd1.ExecuteNonQuery();
                        try
                        {
                            
                            
                            if (res == 1 && res1==1)
                            {
                                MessageBox.Show("Registration Has Been Successfull");
                                txtregid.Clear();
                                txtstuname.Clear();
                                txtaddress.Clear();
                                txtcontactno.Clear();
                                dateTimePicker1.Text = DateTime.Now.ToString();
                                radioButton1.Checked = false; ;
                                radioButton2.Checked = false; ;
                                CBCourseEnroll.Refresh();
                                CBqualificatin.Text="Select Qualification";

                            }
                            else
                            {
                                MessageBox.Show("An Error Occur During Registration");
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            con.CloseConnection();
                            frmStudentregister_Load(sender, e);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Select CourseName");
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Qualification");
                }
            }
            else
            {
                MessageBox.Show("Please Select Gender");
            }
        }
    }
}

