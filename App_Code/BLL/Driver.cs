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
            this.FName = fName;
            this.LName = lName;
            this.occAccountant = occupation;
            this.dob = dob;
            this.age = today.Year - dob.Year;
        }
        //accessors for encapsulation purposes
        public Claim[] ClaimArray
        {
            get
            {
                return this.driverClaims;
            }
        }

        public Claim getClaimAt(int index)
        {
            return driverClaims[index];
        }


        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }

        public Boolean Occ
        {
            get
            {
                return this.occAccountant;
            }
        }

        public String Name
        {
            get
            {
                return this.FName + " " + this.LName;
            }
        }

        public string FName
        {
            get
            {
                return fName;
            }

            set
            {
                fName = value;
            }
        }

        public string LName
        {
            get
            {
                return lName;
            }

            set
            {
                lName = value;
            }
        }



        public int Position
        {
            get
            {
                return this.position;
            }
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

        public int NumOfClaims
        {
            get
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
        }

        //based on criteria for the occupation, a boolean value was used and premium was increased according to if the driver is an accountant or not  

        public void calcDriverOcc()
        {
            if (Occ== true)
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
            for(int index = 0; index < ClaimArray.Length; index++)
            {
                
                if (getClaimAt(index) != null)
                {
                    int claimAge = Global.startDate.Year - getClaimAt(index).ClaimAge.Year;
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


