namespace Institute_Management_System
{
    partial class frmupdatecourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmupdatecourse));
            this.gbfirststep = new System.Windows.Forms.GroupBox();
            this.lblreason1 = new System.Windows.Forms.Label();
            this.btnvalidate = new System.Windows.Forms.Button();
            this.txtcourseid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbsecondstep = new System.Windows.Forms.GroupBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.lblreason2 = new System.Windows.Forms.Label();
            this.txtsecondinstalment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcoursefees = new System.Windows.Forms.TextBox();
            this.txtfirstinstallment = new System.Windows.Forms.TextBox();
            this.txtcourseduration = new System.Windows.Forms.TextBox();
            this.txtcoursename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbfirststep.SuspendLayout();
            this.gbsecondstep.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbfirststep
            // 
            this.gbfirststep.BackColor = System.Drawing.Color.White;
            this.gbfirststep.Controls.Add(this.lblreason1);
            this.gbfirststep.Controls.Add(this.btnvalidate);
            this.gbfirststep.Controls.Add(this.txtcourseid);
            this.gbfirststep.Controls.Add(this.label3);
            this.gbfirststep.Location = new System.Drawing.Point(0, 0);
            this.gbfirststep.Name = "gbfirststep";
            this.gbfirststep.Size = new System.Drawing.Size(408, 90);
            this.gbfirststep.TabIndex = 0;
            this.gbfirststep.TabStop = false;
            this.gbfirststep.Text = "First Step";
            // 
            // lblreason1
            // 
            this.lblreason1.AutoSize = true;
            this.lblreason1.ForeColor = System.Drawing.Color.Red;
            this.lblreason1.Location = new System.Drawing.Point(121, 65);
            this.lblreason1.Name = "lblreason1";
            this.lblreason1.Size = new System.Drawing.Size(0, 13);
            this.lblreason1.TabIndex = 7;
            // 
            // btnvalidate
            // 
            this.btnvalidate.Location = new System.Drawing.Point(310, 29);
            this.btnvalidate.Name = "btnvalidate";
            this.btnvalidate.Size = new System.Drawing.Size(75, 23);
            this.btnvalidate.TabIndex = 6;
            this.btnvalidate.Text = "Validate";
            this.btnvalidate.UseVisualStyleBackColor = true;
            this.btnvalidate.Click += new System.EventHandler(this.btnvalidate_Click);
            // 
            // txtcourseid
            // 
            this.txtcourseid.Location = new System.Drawing.Point(124, 32);
            this.txtcourseid.Name = "txtcourseid";
            this.txtcourseid.Size = new System.Drawing.Size(169, 20);
            this.txtcourseid.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Course ID";
            // 
            // gbsecondstep
            // 
            this.gbsecondstep.BackColor = System.Drawing.Color.White;
            this.gbsecondstep.Controls.Add(this.btnupdate);
            this.gbsecondstep.Controls.Add(this.lblreason2);
            this.gbsecondstep.Controls.Add(this.txtsecondinstalment);
            this.gbsecondstep.Controls.Add(this.label6);
            this.gbsecondstep.Controls.Add(this.label5);
            this.gbsecondstep.Controls.Add(this.label4);
            this.gbsecondstep.Controls.Add(this.label2);
            this.gbsecondstep.Controls.Add(this.txtcoursefees);
            this.gbsecondstep.Controls.Add(this.txtfirstinstallment);
            this.gbsecondstep.Controls.Add(this.txtcourseduration);
            this.gbsecondstep.Controls.Add(this.txtcoursename);
            this.gbsecondstep.Controls.Add(this.label1);
            this.gbsecondstep.Location = new System.Drawing.Point(0, 96);
            this.gbsecondstep.Name = "gbsecondstep";
            this.gbsecondstep.Size = new System.Drawing.Size(394, 295);
            this.gbsecondstep.TabIndex = 7;
            this.gbsecondstep.TabStop = false;
            this.gbsecondstep.Text = "Second Step";
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(124, 266);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 8;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // lblreason2
            // 
            this.lblreason2.AutoSize = true;
            this.lblreason2.ForeColor = System.Drawing.Color.Red;
            this.lblreason2.Location = new System.Drawing.Point(121, 243);
            this.lblreason2.Name = "lblreason2";
            this.lblreason2.Size = new System.Drawing.Size(0, 13);
            this.lblreason2.TabIndex = 8;
            // 
            // txtsecondinstalment
            // 
            this.txtsecondinstalment.Location = new System.Drawing.Point(124, 211);
            this.txtsecondinstalment.Name = "txtsecondinstalment";
            this.txtsecondinstalment.Size = new System.Drawing.Size(169, 20);
            this.txtsecondinstalment.TabIndex = 14;
            this.txtsecondinstalment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsecondinstalment_KeyPress);
            this.txtsecondinstalment.Leave += new System.EventHandler(this.txtsecondinstalment_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(6, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Second Installment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(6, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "First Installment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(6, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Course Fees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Course Duration";
            // 
            // txtcoursefees
            // 
            this.txtcoursefees.Location = new System.Drawing.Point(124, 125);
            this.txtcoursefees.Name = "txtcoursefees";
            this.txtcoursefees.Size = new System.Drawing.Size(169, 20);
            this.txtcoursefees.TabIndex = 9;
            this.txtcoursefees.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcoursefees_KeyPress);
            this.txtcoursefees.Leave += new System.EventHandler(this.txtcoursefees_Leave);
            // 
            // txtfirstinstallment
            // 
            this.txtfirstinstallment.Location = new System.Drawing.Point(124, 173);
            this.txtfirstinstallment.Name = "txtfirstinstallment";
            this.txtfirstinstallment.Size = new System.Drawing.Size(169, 20);
            this.txtfirstinstallment.TabIndex = 8;
            this.txtfirstinstallment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfirstinstallment_KeyPress);
            this.txtfirstinstallment.Leave += new System.EventHandler(this.txtfirstinstallment_Leave);
            // 
            // txtcourseduration
            // 
            this.txtcourseduration.Location = new System.Drawing.Point(124, 82);
            this.txtcourseduration.Name = "txtcourseduration";
            this.txtcourseduration.Size = new System.Drawing.Size(169, 20);
            this.txtcourseduration.TabIndex = 7;
            this.txtcourseduration.Leave += new System.EventHandler(this.txtcourseduration_Leave);
            // 
            // txtcoursename
            // 
            this.txtcoursename.Location = new System.Drawing.Point(124, 32);
            this.txtcoursename.Name = "txtcoursename";
            this.txtcoursename.Size = new System.Drawing.Size(169, 20);
            this.txtcoursename.TabIndex = 6;
            this.txtcoursename.Leave += new System.EventHandler(this.txtcoursename_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Course Name";
            // 
            // frmupdatecourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 410);
            this.Controls.Add(this.gbsecondstep);
            this.Controls.Add(this.gbfirststep);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmupdatecourse";
            this.Text = "Update Course";
            this.Load += new System.EventHandler(this.frmupdatecourse_Load);
            this.gbfirststep.ResumeLayout(false);
            this.gbfirststep.PerformLayout();
            this.gbsecondstep.ResumeLayout(false);
            this.gbsecondstep.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbfirststep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcourseid;
        private System.Windows.Forms.Button btnvalidate;
        private System.Windows.Forms.GroupBox gbsecondstep;
        private System.Windows.Forms.TextBox txtsecondinstalment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcoursefees;
        private System.Windows.Forms.TextBox txtfirstinstallment;
        private System.Windows.Forms.TextBox txtcourseduration;
        private System.Windows.Forms.TextBox txtcoursename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblreason1;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label lblreason2;
    }
}