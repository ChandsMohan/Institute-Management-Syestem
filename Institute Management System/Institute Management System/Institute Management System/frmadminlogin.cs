using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Institute_Management_System
{
    public partial class frmadminlogin : Form
    {
        Logic lo = new Logic();
        DBConnect con = new DBConnect();
        public static string AdminID;
        public frmadminlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////DataTable dt = con.ExecuteDataTable("select * from tbl_login where UserName='" + textBox1.Text + "' and Password='" + textBox2.Text + "'");
            try
            {
                con.OpenConnection();
                string str = "select * from tbl_login where UserName='" + txtusername.Text + "' and Password='" + txtpwd.Text + "'";
                SqlCommand cmd = new SqlCommand(str, DBConnect.connection);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    frmMDIMaster obj = new frmMDIMaster();
                    this.Hide();
                    obj.Show();
                    //obj.label1.BackColor = Color.Black;
                    obj.label1.ForeColor = Color.White;
                    obj.label1.Text = "Your Last Login Time " + dr.GetValue(2).ToString();
                    AdminID = txtusername.Text;
                }
                else
                {
                    lblinvaliduserpwd.Text = "Invalid User Name Or Password \n Please Enter Correct User Name And Password";
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
            //DataTable dt = new DataTable();
            //dt = lo.ExecuteDataTable("select * from tbl_login where UserName='" + txtusername.Text + "' and Password='" + txtpwd.Text + "'");
            //if (dt.Rows.Count > 0)
            //{
            //    frmMDI obj = new frmMDI();
            //    this.Hide();
            //    obj.Show();
            //}

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtusername.Text.Trim().Length.Equals(0))
            {
                //lblusername.BackColor = Color.Red;
                lblusername.ForeColor = Color.Red;
                lblusername.Text = "Please Enter User Name First";
                lblusername.Focus();
            }
        }

        private void txtpwd_Leave(object sender, EventArgs e)
        {
            if (txtpwd.Text.Length.Equals(0))
            {
                lblpwd.ForeColor = Color.Red;
                lblpwd.Text = "Please Enter Your Password";
                lblpwd.Focus();
            }
        }

        private void frmadminlogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Do You Want to Exit", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
                Application.Exit();
            }
        }

        public bool LoginDetails(string AdminId, string Lastlogintime)
        {
            DateTime datetime = DateTime.Now;
            string date = datetime.ToString();
            bool b = false;
            try
            {
                con.OpenConnection();
                string strquery = "update tbl_login set LastLogin='" + date + "' where UserName='" + AdminID + "'";
                SqlCommand cmd = new SqlCommand(strquery, DBConnect.connection);
                int res = cmd.ExecuteNonQuery();
                if (res >= 1)
                {
                    b = true;
                    return b;
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
            return b;
        }
    }
}
