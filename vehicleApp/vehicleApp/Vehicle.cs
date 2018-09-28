using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vehicleApp
{
    [Serializable]


    public class Vehicle
    {
        public string name;
        public int regNo;
      public   List<double> speedList = new List<double>();
        public double GetMaxSpeed() {
           return speedList.Max();
        
        }
        public double GetMinSpeed() {
            return speedList.Min();

        }
        public double GetAvgSpeed() {
            return speedList.Average();
        }
 
    }

    }
