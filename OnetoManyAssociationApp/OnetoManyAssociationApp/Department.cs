using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnetoManyAssociationApp
{
    public class Department
    {
        public string  Code { get; set; }
        public string Name { get; set; }


        public Department(string code, string name)
        {

            code = Code;
            name = Name;
        }

        public Department()
        {
            
        }
    }
}