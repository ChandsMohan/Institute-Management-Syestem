namespace Institute_Management_System
{
    partial class frmMDIMaster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMDIMaster));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.studentRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentRegistrationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.collectFeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstInstallmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secondInstallmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCourseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentsFeesRecordsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.courseDetailsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(620, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentRegistrationToolStripMenuItem,
            this.collectFeesToolStripMenuItem,
            this.courseDetailsToolStripMenuItem,
            this.studentsDetailsToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(693, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // studentRegistrationToolStripMenuItem
            // 
            this.studentRegistrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentRegistrationToolStripMenuItem1});
            this.studentRegistrationToolStripMenuItem.Name = "studentRegistrationToolStripMenuItem";
            this.studentRegistrationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.studentRegistrationToolStripMenuItem.Text = "Registration";
            // 
            // studentRegistrationToolStripMenuItem1
            // 
            this.studentRegistrationToolStripMenuItem1.Name = "studentRegistrationToolStripMenuItem1";
            this.studentRegistrationToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.studentRegistrationToolStripMenuItem1.Text = "StudentRegistration ";
            this.studentRegistrationToolStripMenuItem1.Click += new System.EventHandler(this.studentRegistrationToolStripMenuItem1_Click);
            // 
            // collectFeesToolStripMenuItem
            // 
            this.collectFeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstInstallmentToolStripMenuItem,
            this.secondInstallmentToolStripMenuItem});
            this.collectFeesToolStripMenuItem.Name = "collectFeesToolStripMenuItem";
            this.collectFeesToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.collectFeesToolStripMenuItem.Text = "Collect Fees";
            this.collectFeesToolStripMenuItem.Click += new System.EventHandler(this.collectFeesToolStripMenuItem_Click);
            // 
            // firstInstallmentToolStripMenuItem
            // 
            this.firstInstallmentToolStripMenuItem.Name = "firstInstallmentToolStripMenuItem";
            this.firstInstallmentToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.firstInstallmentToolStripMenuItem.Text = "First Installment";
            this.firstInstallmentToolStripMenuItem.Click += new System.EventHandler(this.firstInstallmentToolStripMenuItem_Click);
            // 
            // secondInstallmentToolStripMenuItem
            // 
            this.secondInstallmentToolStripMenuItem.Name = "secondInstallmentToolStripMenuItem";
            this.secondInstallmentToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.secondInstallmentToolStripMenuItem.Text = "Second Installment";
            this.secondInstallmentToolStripMenuItem.Click += new System.EventHandler(this.secondInstallmentToolStripMenuItem_Click);
            // 
            // courseDetailsToolStripMenuItem
            // 
            this.courseDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateCourseToolStripMenuItem,
            this.updateCourseToolStripMenuItem1});
            this.courseDetailsToolStripMenuItem.Name = "courseDetailsToolStripMenuItem";
            this.courseDetailsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.courseDetailsToolStripMenuItem.Text = "Courses";
            // 
            // updateCourseToolStripMenuItem
            // 
            this.updateCourseToolStripMenuItem.Name = "updateCourseToolStripMenuItem";
            this.updateCourseToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.updateCourseToolStripMenuItem.Text = "Add New Course";
            this.updateCourseToolStripMenuItem.Click += new System.EventHandler(this.updateCourseToolStripMenuItem_Click);
            // 
            // updateCourseToolStripMenuItem1
            // 
            this.updateCourseToolStripMenuItem1.Name = "updateCourseToolStripMenuItem1";
            this.updateCourseToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.updateCourseToolStripMenuItem1.Text = "Update Course";
            this.updateCourseToolStripMenuItem1.Click += new System.EventHandler(this.updateCourseToolStripMenuItem1_Click);
            // 
            // studentsDetailsToolStripMenuItem
            // 
            this.studentsDetailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsReportToolStripMenuItem,
            this.StudentsFeesRecordsToolStripMenuItem1,
            this.courseDetailsToolStripMenuItem2});
            this.studentsDetailsToolStripMenuItem.Name = "studentsDetailsToolStripMenuItem";
            this.studentsDetailsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.studentsDetailsToolStripMenuItem.Text = "Report";
            // 
            // studentsReportToolStripMenuItem
            // 
            this.studentsReportToolStripMenuItem.Name = "studentsReportToolStripMenuItem";
            this.studentsReportToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.studentsReportToolStripMenuItem.Text = "Students Record";
            this.studentsReportToolStripMenuItem.Click += new System.EventHandler(this.studentsReportToolStripMenuItem_Click);
            // 
            // StudentsFeesRecordsToolStripMenuItem1
            // 
            this.StudentsFeesRecordsToolStripMenuItem1.Name = "StudentsFeesRecordsToolStripMenuItem1";
            this.StudentsFeesRecordsToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.StudentsFeesRecordsToolStripMenuItem1.Text = "Students Fees Records";
            this.StudentsFeesRecordsToolStripMenuItem1.Click += new System.EventHandler(this.StudentsFeesRecordsToolStripMenuItem1_Click);
            // 
            // courseDetailsToolStripMenuItem2
            // 
            this.courseDetailsToolStripMenuItem2.Name = "courseDetailsToolStripMenuItem2";
            this.courseDetailsToolStripMenuItem2.Size = new System.Drawing.Size(191, 22);
            this.courseDetailsToolStripMenuItem2.Text = "Course Details";
            this.courseDetailsToolStripMenuItem2.Click += new System.EventHandler(this.courseDetailsToolStripMenuItem2_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // frmMDIMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(693, 437);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMDIMaster";
            this.Text = "Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMDIMaster_FormClosing);
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem studentRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentRegistrationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem collectFeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstInstallmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secondInstallmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCourseToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem studentsDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StudentsFeesRecordsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem courseDetailsToolStripMenuItem2;
    }
}