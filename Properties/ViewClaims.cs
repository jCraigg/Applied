using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppliedSysMotors.Properties
{
    public partial class ViewClaims : Form
    {
        public ViewClaims()
        {
            InitializeComponent();
            for (int index = 0; index < Global.newPolicy.getDriverAt(Global.position).getClaimArray().Length; index++)
            {
                if (Global.newPolicy.getDriverAt(index) != null)
                {

                    
                    switch (index)
                    {
                        case 0:
                            lblClaim1Details.Text = Global.newPolicy.getDriverName(0) + " \tClaims: " + Global.newPolicy.getDriverAt(0).getNumOfClaims();
                            break;
                        case 1:
                            lblClaim2Details.Text = Global.newPolicy.getDriverName(1) + " \tClaims: " + Global.newPolicy.getDriverAt(1).getNumOfClaims();
                            break;
                        case 2:
                            lblClaim3Details.Text = Global.newPolicy.getDriverName(2) + " \tClaims: " + Global.newPolicy.getDriverAt(2).getNumOfClaims();
                            break;
                        case 3:
                            lblClaim4Details.Text = Global.newPolicy.getDriverName(3) + " \tClaims: " + Global.newPolicy.getDriverAt(3).getNumOfClaims();
                            break;
                        case 4:
                            lblClaim5Details.Text = Global.newPolicy.getDriverName(4) + " \tClaims: " + Global.newPolicy.getDriverAt(4).getNumOfClaims();
                            break;
                    }



                }

            }
        }
    }
}
