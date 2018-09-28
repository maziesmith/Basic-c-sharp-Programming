using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SessionApp
{
    public class Person
    {
        public string  Name { get; set; }
        public string Email { get; set; }
        public String Phone { get; set; }

        public Person(string name, string email, string phone)
        {
            name = Name;
            email = Email;
            phone = Phone;



        }

        public Person()
        {
        }


    }
}