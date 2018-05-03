using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedSysMotors.App_Code.BLL
{
    class Claim
    {
        //private variables to ensure encapsulation
        private String claimType;
        private DateTime claimAge;
        private const int END = 5;
        


        public Claim(DateTime age, String claimType)
        {
            this.claimAge = age;
            this.claimType = claimType;
            
        }
        //accessors for encapsulation purposes
        public DateTime ClaimAge
        {
            get
            {

                return this.claimAge;
            }
        }


        public String ClaimType
        {
            get
            {
                return this.claimType;
            }

            set
            {
                this.claimType = value;
            }
        }

        public String ClaimDate
        {
            get
            {
                return this.claimAge.ToLongDateString();
            }
        }
    }
}
