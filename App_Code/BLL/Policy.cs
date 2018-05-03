using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedSysMotors.App_Code.BLL
{
    class Policy
    {
        //private variables to ensure encapsulation
        private int position = 0,totalClaims;
        private const int END = 5;
        private Driver[] policyDrivers = new Driver[5];
        private DateTime policyDate;
        private Driver youngestDriver,oldestDriver;

        //default constructor
        public Policy()
        {

        }
        //accessors for encapsulation purposes

        public int TotalOfClaims
        {
            get
            {
                return this.totalClaims;
            }

            set
            {
                this.totalClaims = value;
            }
        }

        public void incrementTotalClaims()
        {
            this.totalClaims++;
        }

        public Driver YoungestDriver
        {
            get
            {
                return this.youngestDriver;
            }

            set
            {
                this.youngestDriver = value;
            }
        }

        public String YoungestDriverName
        {
            get
            {
                return this.youngestDriver.Name;
            }
        }

        public int YoungestDriverAge
        {
            get
            {
                return this.youngestDriver.Age;
            }
        }

        public Driver OldestDriver
        {
            get
            {
                return this.oldestDriver;
            }

            set
            {
                this.oldestDriver = value;
            }
        }

        public String OldestDriverName
        {
            get
            {
                return this.oldestDriver.Name;
            }
        }

        public int OldestDriverAge
        {
            get
            {
                return this.oldestDriver.Age;
            }
        }

        public Driver[] DriverArray
        {
            get
            {
                return this.policyDrivers;
            }
        }

        public int Position
        {
            get
            {
                return this.position;
            }
        }

        public Driver getDriverAt(int index)
        {
            return policyDrivers[index];
        }

        public String getDriverName(int index)
        {
            String name;
            name = policyDrivers[index].Name;
            return name;
        }
        //takes the driver parameter and adds it to the driver and ensures you can not go past the array limit
        public String addToArray(Driver newDriver)
        {
            StringBuilder sb = new StringBuilder();
            if (position < END)
            {
                policyDrivers[position] = newDriver;
                position++;
                sb.Append("Driver added successfully");
            }
            else
            {
                sb.Append("You cannot have any additional Driver");
            }
            return sb.ToString();

        } 

        public void setPolicyDate(DateTime startDate)
        {
            this.policyDate = startDate;
        }
     
    }

}
