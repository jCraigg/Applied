using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedSysMotors.App_Code.BLL
{
    class Driver
    {
        //private variables to ensure encapsulation
        private String fName, lName;
        private int age,TotalOfClaims=0, position = 0;
        private Boolean occAccountant;
        private const int END = 5;
        private DateTime dob;
        private Claim[] driverClaims= new Claim[5];
            


        public Driver(String fName, String lName, DateTime dob,Boolean occupation, DateTime today)
        {
            this.fName = fName;
            this.lName = lName;
            this.occAccountant = occupation;
            this.dob = dob;
            this.age = today.Year - dob.Year;
        }
        //accessors for encapsulation purposes
        public Claim[] getClaimArray()
        {
            return this.driverClaims;
        }
        public Claim getClaimAt(int index)
        {
            return driverClaims[index];
        }
        
        public int getAge()
        {
            return this.age;
        }

        public Boolean getOcc()
        {
            return this.occAccountant;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public String getName()
        {
            return this.fName + " " + this.lName;
        }

        public void setFName(String fname)
        {
            this.fName = fname;
        }
        public void setLname(String lname)
        {
            this.lName = lname;
        }

        public int getPosition()
        {
            return this.position;
        }

        public String addToArray(Claim newClaim)
        {
            
            StringBuilder sb = new StringBuilder();
            if (position < END)
            {
                driverClaims[position] = newClaim;
                position++;
                TotalOfClaims++;
                sb.Append("Claim added successfully");
            }
            else
            {
                sb.Append("You cannot have any additional claims");
            }
            return sb.ToString();

        }

        public int getNumOfClaims()
        {
            //loops the claim array, increments for each value that isn't null and returns the int
            int numberOfClaims = 0;
            for (int index = 0; index < driverClaims.Length; index++)
            {
                if (driverClaims[index] != null)
                {
                    numberOfClaims++;
                }
            }
            return numberOfClaims;
        }
        //based on criteria for the occupation, a boolean value was used and premium was increased according to if the driver is an accountant or not  

        public void calcDriverOcc()
        {
            if (getOcc() == true)
            {
                Global.premium = Global.premium * 0.9;
            }
            else
            {
                Global.premium  = Global.premium  * 1.1;
            }

        }
        //using the age parameter it changes the premium based on how old they are
        public void calcAgePremium(int age)
        {

            if (age >= 21 && age <= 25)
            {
                Global.premium = Global.premium * 1.2;
            }
            else if (age >= 26 && age <= 75)
            {
                Global.premium = Global.premium * 1.1;
            }
            //no calculation for younger than 21 and older than 75 because it will decline the policy
        }//end of calcAgePremium

        public void calcClaimPremium()
        {//loops through claim array and for each value that is not null calculates its age, depending on the age of that claim it adjusts the premium
            for(int index = 0; index < getClaimArray().Length; index++)
            {
                
                if (getClaimAt(index) != null)
                {
                    int claimAge = Global.startDate.Year - getClaimAt(index).getClaimAge().Year;
                    if (claimAge <= 1)
                    {
                        Global.premium = Global.premium * 1.2;
                    }
                    else if (claimAge >= 2 && claimAge <= 5)
                    {
                        Global.premium = Global.premium * 1.1;
                    }
                }
                else
                {
                    continue;
                }//end of if
            }//end of for
            
        }//end of calcClaimPremium
    }
}


