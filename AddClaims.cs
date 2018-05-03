using AppliedSysMotors.App_Code.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppliedSysMotors
{
    public partial class AddClaims : Form
    {
        public AddClaims()
        {
            //ensures the user cannot create a claim in the future
            InitializeComponent();
            dtpClaimDate.MaxDate = DateTime.Today;
        }

        private void btnAddClaim_Click(object sender, EventArgs e)
        {
            //Will check if the array is full before attempting to add one
            if(Global.newPolicy.getDriverAt(Global.position).Position== 5)
            {
                MessageBox.Show("This driver has reached its claim capacity");
            }
            else
            {
                //the data from the user input is passed through to the claim constructor
                if (Global.newPolicy.getDriverAt(Global.position).getClaimAt(Global.newPolicy.getDriverAt(Global.position).Position) == null)
                {   //ensures all data is entered before creating a claim object
                    if (ddlClaimType != null && dtpClaimDate.Value <= dtpClaimDate.Value.ToLocalTime())
                    {
                        Claim newClaim = new App_Code.BLL.Claim(Convert.ToDateTime(dtpClaimDate.Text), ddlClaimType.Text.ToString());
                        Global.newPolicy.getDriverAt(Global.position).addToArray(newClaim);
                        Global.newPolicy.incrementTotalClaims();
                        lblOutput.Text = "Claim added";
                    }
                    else
                    {
                        MessageBox.Show("Please fill in all details");
                    }
                }
            }
        }

        private void AddClaims_FormClosing(object sender, FormClosingEventArgs e)
        {
            //reopens the driver details form

            Driver_Details driverDetails = new Driver_Details();
            driverDetails.Show();
        }

        private void ddlClaimType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
