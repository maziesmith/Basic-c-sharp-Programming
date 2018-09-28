using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingApp
{
    class Calculator
    {
        public double Add(double num1, double num2) {

            return num1 + num2;
        }

        public double Add(double num1, double num2, double num3)
        {
            return num1 + num2 + num3;
        
        }
        public double Subtract(double num1, double num2) {

            return num1 - num2;
        }
        public double Multiply(double num1, double num2)
        {

            return num1*num2;

        }

        public double Divide(double num1, double num2)
        {

            return num1/num2;

        
       }
   
    }
}
