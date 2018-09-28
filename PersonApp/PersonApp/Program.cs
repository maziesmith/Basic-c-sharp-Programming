using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person a = new Person();
            a.firstName = Console.ReadLine();
            a.middleName = Console.ReadLine();
            a.lastName = Console.ReadLine();
            a.GetFullName();
           Console.WriteLine( a.GetReverseName());
            Console.ReadLine();

        }
    }
}
