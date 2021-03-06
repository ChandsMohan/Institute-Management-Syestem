﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace Institute_Management_System
{
    public partial class frmStudentReport : Form
    {
        DirectoryInfo Student_Report;
        DBConnect con = new DBConnect();
        Timer timer1 = new Timer();
        
        public frmStudentReport()
        {
            InitializeComponent();
        }

        private void frmStudentReport_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Tick += new EventHandler(timer1_Tick);
            dataGridView1.Columns.Add("1", "Registration Number");
            dataGridView1.Columns.Add("2", "Student Name");
            dataGridView1.Columns.Add("3", "Address");
            dataGridView1.Columns.Add("4", "Contact No");
            dataGridView1.Columns.Add("5", "Date Of Birth");
            dataGridView1.Columns.Add("6", "Gender");
            dataGridView1.Columns.Add("7", "Qualification");
            dataGridView1.Columns.Add("8", "Course Enroll");
            dataGridView1.Columns.Add("9", "Registration Fees");
            BindGrid();


        }

        public void BindGrid()
        {
            try
            {
                con.OpenConnection();
                string query = "Select Registration_Id,Name,Address,Contact_No,DOB,Gender,Qualification,CourseEnroll,Registration_fee from tbl_registration";
                SqlCommand cmd = new SqlCommand(query, DBConnect.connection);
                SqlDataReader dr = cmd.ExecuteReader();
                int record = 0;
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        int n = dataGridView1.Rows.Add();
                        for (int i = 0; i < 9; i++)
                        {
                            dataGridView1.Rows[n].Cells[i].Value = dr.GetValue(i).ToString();
                        }
                        record++;
                    }
                    toolStripLabel1.Text = record + " Records Found";

                }
                else
                {
                    toolStripLabel1.Text = "No Record Found";
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

        void timer1_Tick(object sender, EventArgs e)
        {
            toolStripLabel2.Text = DateTime.Now.ToString();
        }

        private void frmStudentReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do You Want to Close", "Close", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();


            // creating new WorkBook within Excel application
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);


            // creating new Excelsheet in workbook
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            // see the excel sheet behind the program
            app.Visible = true;

            // get the reference of first sheet. By default its name is Sheet1.
            // store its reference to worksheet
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;

            // changing the name of active sheet
            worksheet.Name = "Exported from gridview";


            // storing header part in Excel
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }



            // storing Each row and column value to excel sheet
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString().Trim();
                }
            }


            // save the application
            DirectoryInfo Student_Report = new DirectoryInfo(Application.StartupPath + "//Student_Report//");
            if (Student_Report.Exists)
            {
            }
            else
            {
                Student_Report.Create();
            }
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            workbook.SaveAs(Application.StartupPath + "\\Student_Report\\" + System.DateTime.Now.ToString("dd-MMM-yy") + ".xls");
        }
    }
}

