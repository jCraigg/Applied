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
    public partial class ViewClaims : Form
    {
        public ViewClaims()
        {
            //on load of the form the lbls set the string to empty incase any leftover strings remain
            InitializeComponent();
            lblClaimType1Details.Text = "";
            lblClaimType2Details.Text = "";
            lblClaimType3Details.Text = "";
            lblClaimtype4Details.Text = "";
            lblClaimType5Details.Text = "";
            //populating the labels by looping through the previously choosen driver's claim array
            for (int index = 0; index < Global.newPolicy.getDriverAt(Global.position).getClaimArray().Length; index++)
            {
                //if the value of the claim array is not null it will continue to set the details for the label
                if (Global.newPolicy.getDriverAt(Global.position).getClaimAt(index) != null)
                {

                    //using the position of the for loop a switch was used to populate its respective label
                    switch (index)
                    {
                        //for each label it will retrieve the drivers claim type and date using the global position to retrieve the correct driver
                        case 0:
                            lblClaimType1Details.Text = Global.newPolicy.getDriverAt(Global.position).getClaimAt(0).getClaimType();
                            lblClaimDate1.Text = Global.newPolicy.getDriverAt(Global.position).getClaimAt(0).getClaimDate();
                            break;
                        case 1:
                            lblClaimType2Details.Text = Global.newPolicy.getDriverAt(Global.position).getClaimAt(1).getClaimType();
                            lblClaimDate2.Text = Global.newPolicy.getDriverAt(Global.position).getClaimAt(1).getClaimDate();
                            break;
                        case 2:
                            lblClaimType3Details.Text = Global.newPolicy.getDriverAt(Global.position).getClaimAt(2).getClaimType();
                            lblClaimDate3.Text = Global.newPolicy.getDriverAt(Global.position).getClaimAt(2).getClaimDate();
                            break;
                        case 3:
                            lblClaimtype4Details.Text = Global.newPolicy.getDriverAt(Global.position).getClaimAt(3).getClaimType();
                            lblClaimDate4.Text = Global.newPolicy.getDriverAt(Global.position).getClaimAt(3).getClaimDate();
                            break;
                        case 4:
                            lblClaimType5Details.Text = Global.newPolicy.getDriverAt(Global.position).getClaimAt(4).getClaimType();
                            lblClaimDate5.Text = Global.newPolicy.getDriverAt(Global.position).getClaimAt(4).getClaimDate();
                            break;
                    }



                }

            }
        }

        private void ViewClaims_FormClosing(object sender, FormClosingEventArgs e)
        {

            Driver_Details driverDetails = new Driver_Details();
            driverDetails.Show();
            //Global.position = -1;
        }


    }
}
