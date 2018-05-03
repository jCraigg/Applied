namespace AppliedSysMotors
{
    partial class AddDriver
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDriver));
            this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblForeName = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.lblTodaysDate = new System.Windows.Forms.Label();
            this.btnViewDrivers = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.chkAccountant = new System.Windows.Forms.CheckBox();
            this.chkChauffeur = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpBirthdate
            // 
            this.dtpBirthdate.Location = new System.Drawing.Point(92, 145);
            this.dtpBirthdate.Name = "dtpBirthdate";
            this.dtpBirthdate.Size = new System.Drawing.Size(261, 20);
            this.dtpBirthdate.TabIndex = 0;
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(92, 117);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(100, 20);
            this.txtForename.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(10, 96);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(89, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Policy Start Date:";
            // 
            // lblForeName
            // 
            this.lblForeName.AutoSize = true;
            this.lblForeName.Location = new System.Drawing.Point(7, 125);
            this.lblForeName.Name = "lblForeName";
            this.lblForeName.Size = new System.Drawing.Size(54, 13);
            this.lblForeName.TabIndex = 3;
            this.lblForeName.Text = "Forename";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(7, 151);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(69, 13);
            this.lblBirthdate.TabIndex = 4;
            this.lblBirthdate.Text = "Date of Birth:";
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Location = new System.Drawing.Point(7, 171);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(62, 13);
            this.lblOccupation.TabIndex = 7;
            this.lblOccupation.Text = "Occupation";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(198, 124);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(49, 13);
            this.lblSurname.TabIndex = 8;
            this.lblSurname.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(253, 117);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 9;
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Location = new System.Drawing.Point(10, 230);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(75, 23);
            this.btnAddDriver.TabIndex = 10;
            this.btnAddDriver.Text = "Add Driver";
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // lblTodaysDate
            // 
            this.lblTodaysDate.AutoSize = true;
            this.lblTodaysDate.Location = new System.Drawing.Point(105, 96);
            this.lblTodaysDate.Name = "lblTodaysDate";
            this.lblTodaysDate.Size = new System.Drawing.Size(0, 13);
            this.lblTodaysDate.TabIndex = 12;
            // 
            // btnViewDrivers
            // 
            this.btnViewDrivers.Location = new System.Drawing.Point(89, 230);
            this.btnViewDrivers.Name = "btnViewDrivers";
            this.btnViewDrivers.Size = new System.Drawing.Size(75, 23);
            this.btnViewDrivers.TabIndex = 14;
            this.btnViewDrivers.Text = "View drivers";
            this.btnViewDrivers.UseVisualStyleBackColor = true;
            this.btnViewDrivers.Click += new System.EventHandler(this.btnViewDrivers_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppliedSysMotors.Properties.Resources.applied_22;
            this.pictureBox1.Location = new System.Drawing.Point(10, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 64);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(7, 196);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "Status";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(92, 196);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 17;
            // 
            // chkAccountant
            // 
            this.chkAccountant.AutoSize = true;
            this.chkAccountant.Location = new System.Drawing.Point(92, 171);
            this.chkAccountant.Name = "chkAccountant";
            this.chkAccountant.Size = new System.Drawing.Size(81, 17);
            this.chkAccountant.TabIndex = 18;
            this.chkAccountant.Text = "Accountant";
            this.chkAccountant.UseVisualStyleBackColor = true;
            this.chkAccountant.CheckedChanged += new System.EventHandler(this.chkAccountant_CheckedChanged);
            // 
            // chkChauffeur
            // 
            this.chkChauffeur.AutoSize = true;
            this.chkChauffeur.Location = new System.Drawing.Point(179, 171);
            this.chkChauffeur.Name = "chkChauffeur";
            this.chkChauffeur.Size = new System.Drawing.Size(72, 17);
            this.chkChauffeur.TabIndex = 19;
            this.chkChauffeur.Text = "Chauffeur";
            this.chkChauffeur.UseVisualStyleBackColor = true;
            this.chkChauffeur.CheckedChanged += new System.EventHandler(this.chkChauffeur_CheckedChanged);
            // 
            // AddDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(396, 265);
            this.Controls.Add(this.chkChauffeur);
            this.Controls.Add(this.chkAccountant);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnViewDrivers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTodaysDate);
            this.Controls.Add(this.btnAddDriver);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblOccupation);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.lblForeName);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtForename);
            this.Controls.Add(this.dtpBirthdate);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDriver";
            this.Text = "Insurance Policy";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpBirthdate;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblForeName;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.Label lblTodaysDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnViewDrivers;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.CheckBox chkAccountant;
        private System.Windows.Forms.CheckBox chkChauffeur;
    }
}

