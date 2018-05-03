using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedSysMotors
{
    class Global
    {
        //because there is only one policy I declared and initialised some variables at a global level so they would be accessible throughout
        public static App_Code.BLL.Policy newPolicy = new App_Code.BLL.Policy();
        public static int position = -1;
        public static double premium = 500;
        public static DateTime startDate = DateTime.Now.ToLocalTime();
        
    }
}
