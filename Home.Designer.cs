namespace AppliedSysMotors
{
    partial class Home
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
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblPolStart = new System.Windows.Forms.Label();
            this.btnAddDrivers = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnViewDrivers = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblCurrentDrivers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(108, 112);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(136, 20);
            this.dtpStartDate.TabIndex = 15;
            // 
            // lblPolStart
            // 
            this.lblPolStart.AutoSize = true;
            this.lblPolStart.Location = new System.Drawing.Point(13, 119);
            this.lblPolStart.Name = "lblPolStart";
            this.lblPolStart.Size = new System.Drawing.Size(89, 13);
            this.lblPolStart.TabIndex = 16;
            this.lblPolStart.Text = "Policy Start Date:";
            // 
            // btnAddDrivers
            // 
            this.btnAddDrivers.Location = new System.Drawing.Point(16, 152);
            this.btnAddDrivers.Name = "btnAddDrivers";
            this.btnAddDrivers.Size = new System.Drawing.Size(86, 23);
            this.btnAddDrivers.TabIndex = 17;
            this.btnAddDrivers.Text = "Add Drivers";
            this.btnAddDrivers.UseVisualStyleBackColor = true;
            this.btnAddDrivers.Click += new System.EventHandler(this.btnAddDrivers_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(108, 152);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(103, 23);
            this.btnCalc.TabIndex = 18;
            this.btnCalc.Text = "Calculate Premium";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppliedSysMotors.Properties.Resources.applied_22;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 64);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // BtnViewDrivers
            // 
            this.BtnViewDrivers.Location = new System.Drawing.Point(16, 181);
            this.BtnViewDrivers.Name = "BtnViewDrivers";
            this.BtnViewDrivers.Size = new System.Drawing.Size(86, 23);
            this.BtnViewDrivers.TabIndex = 19;
            this.BtnViewDrivers.Text = "View Drivers";
            this.BtnViewDrivers.UseVisualStyleBackColor = true;
            this.BtnViewDrivers.Click += new System.EventHandler(this.BtnViewDrivers_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(250, 112);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 20);
            this.btnConfirm.TabIndex = 20;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblCurrentDrivers
            // 
            this.lblCurrentDrivers.AutoSize = true;
            this.lblCurrentDrivers.Location = new System.Drawing.Point(108, 190);
            this.lblCurrentDrivers.Name = "lblCurrentDrivers";
            this.lblCurrentDrivers.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentDrivers.TabIndex = 21;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(332, 221);
            this.Controls.Add(this.lblCurrentDrivers);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.BtnViewDrivers);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnAddDrivers);
            this.Controls.Add(this.lblPolStart);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblPolStart;
        private System.Windows.Forms.Button btnAddDrivers;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button BtnViewDrivers;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblCurrentDrivers;
    }
}