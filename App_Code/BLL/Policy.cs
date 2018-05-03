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
        public int getTotalOfClaims()
        {
            return this.totalClaims;
        }

        public void setTotalOfClaims(int newTot)
        {
            this.totalClaims = newTot;
        }

        public void incrementTotalClaims()
        {
            this.totalClaims++;
        }

        public Driver getYoungestDriver()
        {
            return this.youngestDriver;
        }
        public String getYoungestDriverName()
        {
            return this.youngestDriver.getName();
        }

        public int getYoungestDriverAge()
        {
            return this.youngestDriver.getAge();
        }

        public void setYoungestDriver(Driver youngestDriver)
        {
            this.youngestDriver = youngestDriver;
        }

        public Driver getOldestDriver()
        {
            return this.oldestDriver;
        }

        public String getOldestDriverName()
        {
            return this.oldestDriver.getName();
        }

        public int getOldestDriverAge()
        {
            return this.oldestDriver.getAge();
        }

        public void setOldestDriver(Driver oldestDriver)
        {
            this.oldestDriver = oldestDriver;
        }


        public Driver[] getDriverArray()
        {
            return this.policyDrivers;
        } 

        public int getPosition()
        {
            return this.position;
        }

        public Driver getDriverAt(int index)
        {
            return policyDrivers[index];
        }

        public String getDriverName(int index)
        {
            String name;
            name = policyDrivers[index].getName();
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
        

        
        

        


        //public String declined()
        //{
        //    StringBuilder sb = new StringBuilder();
        //    if (age < 21)
        //    {
        //        sb.Append("Age of Youngest Driver " + this.fName + " " + this.lName);
        //    }
        //    else if (age > 75)
        //    {
        //        sb.Append("Age of Oldest Driver " + this.fName + " " + this.lName);
        //    }
        //    else if (this.claims > 2)
        //    {
        //        sb.Append("Driver has more than 2 claims " + this.fName + " " + this.lName);
        //    }
        //    else if (this.claims > 3)
        //    {
        //        sb.Append("Policy has more than 3 claims");
        //    }
        //    return sb.ToString();
        //}
    }

}
