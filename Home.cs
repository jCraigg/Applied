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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            //ensures the driver can not select a date prior to today
            dtpStartDate.MinDate = DateTime.Now;
            
        }

        private void btnAddDrivers_Click(object sender, EventArgs e)
        {
            //because the drivers DOB is based on the startdate of policy, before you can add drivers the date needs to be set
            if(Global.startDate == null)
            {
                MessageBox.Show("Please enter a start date for the policy");
            }
            else
            {
                
                AddDriver addDriverWind = new AddDriver();
                addDriverWind.ShowDialog();
            }
            
        }

        private void BtnViewDrivers_Click(object sender, EventArgs e)
        {
            //opens the view driver window
            Driver_Details viewDriver = new Driver_Details();
            viewDriver.ShowDialog();
         }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            /*this button loops through the driver array.
             * for each driver it loops through methods in the driver class to change the premium based on the criteria provided
            */
            for (int index = 0;index<Global.newPolicy.getDriverArray().Length; index++)
            {
                //this if statement ensures it does not call the methods for drivers that don't exist
                //retrieving the driver in the array at the position of the loop and checking it isn't null it will continue
                if (Global.newPolicy.getDriverAt(index) != null)
                {


                    Global.newPolicy.getDriverAt(index).calcDriverOcc();
                    Global.newPolicy.getDriverAt(index).calcAgePremium(Global.newPolicy.getDriverAt(index).getAge());
                    Global.newPolicy.getDriverAt(index).calcClaimPremium();


                    //for (int cIndex = 0; cIndex < Global.newPolicy.getDriverAt(index).getClaimArray().Length; cIndex++)
                    //{
                    //    if (Global.newPolicy.getDriverAt(index).getClaimAt(cIndex) != null)
                    //    {
                    //        Global.newPolicy.getDriverAt(index).calcClaimPremium(Global.newPolicy.getDriverAt(index).getClaimAt(cIndex).getClaimAge());
                    //    }
                    //}
                }
                else
                {
                    //break could have been used as if the driver is null in the array the remaining will too
                    continue;
                }

            }
            //output is used for a switch statement, so it was initialised to 0 to prevent the switch from triggering
            int output = 0;
            //because the driverIndex is used for a position in array later it was initialised to -1 as array start at 0
            int driverIndex = -1;
            //This for loop goes through all the drivers in array and check to see if they trigger the decline criteria
            for (int index = 0; index < Global.newPolicy.getDriverArray().Length; index++)
            {
                if (Global.newPolicy.getYoungestDriverAge() < 21)
                {
                    output = 1;
                    break;
                }
                else if (Global.newPolicy.getOldestDriverAge() > 75)
                {
                    output = 2;
                    break;
                }
                else if (Global.newPolicy.getTotalOfClaims() > 3)
                {
                    output = 3;
                    break;
                }
                else if (Global.newPolicy.getDriverAt(index).getNumOfClaims() > 2)
                {
                    driverIndex = index;
                    output = 4;
                    break;
                }
                else
                {
                    output = 5;
                    break;
                }
            }
            //switch statement based on the results from the loop above, if it passes all the criteria, it will output the premium
            switch (output)
            {
                case 1:
                    MessageBox.Show("Age of Youngest Driver, " + Global.newPolicy.getYoungestDriverName());
                    break;
                case 2:
                    MessageBox.Show("Age of Oldest Driver, " + Global.newPolicy.getOldestDriverName());
                    break;
                case 3:
                    MessageBox.Show("Policy exceeds more than 3 claims");
                    break;
                case 4:
                    MessageBox.Show("Driver has more than 2 claims, " + Global.newPolicy.getDriverAt(driverIndex).getName());
                    break;
                case 5:
                    MessageBox.Show("You premium total is £"+Global.premium.ToString("F"));
                    break;
            }
            
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //Global.newPolicy.setPolicyDate(Convert.ToDateTime(dtpStartDate.ToString()));
                //The date for your premium initializes to today's date if the user does not wish to set it however on-click of this button it will assign it to the requested date
                Global.startDate = dtpStartDate.Value;
                MessageBox.Show("The date set for your new premium is " + Global.startDate.ToLongDateString());

            
        }
    }
}
