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
            for (int index = 0; index < Global.newPolicy.getDriverAt(Global.position).ClaimArray.Length; index++)
            {
                if (Global.newPolicy.getDriverAt(index) != null)
                {

                    
                    switch (index)
                    {
                        case 0:
                            lblClaim1Details.Text = Global.newPolicy.getDriverName(0) + " \tClaims: " + Global.newPolicy.getDriverAt(0).NumOfClaims;
                            break;
                        case 1:
                            lblClaim2Details.Text = Global.newPolicy.getDriverName(1) + " \tClaims: " + Global.newPolicy.getDriverAt(1).NumOfClaims;
                            break;
                        case 2:
                            lblClaim3Details.Text = Global.newPolicy.getDriverName(2) + " \tClaims: " + Global.newPolicy.getDriverAt(2).NumOfClaims;
                            break;
                        case 3:
                            lblClaim4Details.Text = Global.newPolicy.getDriverName(3) + " \tClaims: " + Global.newPolicy.getDriverAt(3).NumOfClaims;
                            break;
                        case 4:
                            lblClaim5Details.Text = Global.newPolicy.getDriverName(4) + " \tClaims: " + Global.newPolicy.getDriverAt(4).NumOfClaims;
                            break;
                    }



                }

            }
        }
    }
}
