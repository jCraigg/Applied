namespace AppliedSysMotors
{
    partial class AddClaims
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
            this.lblDateofClaim = new System.Windows.Forms.Label();
            this.dtpClaimDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddClaim = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlClaimType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDateofClaim
            // 
            this.lblDateofClaim.AutoSize = true;
            this.lblDateofClaim.Location = new System.Drawing.Point(12, 98);
            this.lblDateofClaim.Name = "lblDateofClaim";
            this.lblDateofClaim.Size = new System.Drawing.Size(75, 13);
            this.lblDateofClaim.TabIndex = 0;
            this.lblDateofClaim.Text = "Date Of Claim:";
            // 
            // dtpClaimDate
            // 
            this.dtpClaimDate.Location = new System.Drawing.Point(90, 92);
            this.dtpClaimDate.Name = "dtpClaimDate";
            this.dtpClaimDate.Size = new System.Drawing.Size(155, 20);
            this.dtpClaimDate.TabIndex = 1;
            // 
            // btnAddClaim
            // 
            this.btnAddClaim.Location = new System.Drawing.Point(12, 187);
            this.btnAddClaim.Name = "btnAddClaim";
            this.btnAddClaim.Size = new System.Drawing.Size(75, 23);
            this.btnAddClaim.TabIndex = 2;
            this.btnAddClaim.Text = "Add Claim";
            this.btnAddClaim.UseVisualStyleBackColor = true;
            this.btnAddClaim.Click += new System.EventHandler(this.btnAddClaim_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(87, 151);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppliedSysMotors.Properties.Resources.applied_2;
            this.pictureBox1.Location = new System.Drawing.Point(9, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 68);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 151);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Claim type: ";
            // 
            // ddlClaimType
            // 
            this.ddlClaimType.FormattingEnabled = true;
            this.ddlClaimType.Items.AddRange(new object[] {
            "Breakdown",
            "Windscreen",
            "Key Loss",
            "Key Theft",
            "Accident"});
            this.ddlClaimType.Location = new System.Drawing.Point(90, 119);
            this.ddlClaimType.Name = "ddlClaimType";
            this.ddlClaimType.Size = new System.Drawing.Size(121, 21);
            this.ddlClaimType.TabIndex = 7;
            this.ddlClaimType.SelectedIndexChanged += new System.EventHandler(this.ddlClaimType_SelectedIndexChanged);
            // 
            // AddClaims
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(302, 222);
            this.Controls.Add(this.ddlClaimType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnAddClaim);
            this.Controls.Add(this.dtpClaimDate);
            this.Controls.Add(this.lblDateofClaim);
            this.Name = "AddClaims";
            this.Text = "Claims";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddClaims_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateofClaim;
        private System.Windows.Forms.DateTimePicker dtpClaimDate;
        private System.Windows.Forms.Button btnAddClaim;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlClaimType;
    }
}