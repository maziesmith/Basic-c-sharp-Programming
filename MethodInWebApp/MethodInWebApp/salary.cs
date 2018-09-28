using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MethodInWebApp
{
    [Serializable]
    public class Salary

    {
        public double basicAmount;
        public double houseRentPercentage;
        public double medicalAllowancePercentage;

        public double CalculateSalary() {

            double houserentAmount = basicAmount * (houseRentPercentage / 100);
            double medicalAllowanceAmount = basicAmount * (medicalAllowancePercentage / 100);
            double totalsalay = basicAmount + houserentAmount + medicalAllowanceAmount;
            


            return totalsalay;
        
        }


    }
}