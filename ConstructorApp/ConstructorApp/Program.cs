using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the value of a and b:");
            int x = Convert.ToInt16(Console.ReadLine());
            int y = Convert.ToInt16(Console.ReadLine());
            Exercise obj = new Exercise(x, y);
            Exercise obj1 = new Exercise();
            obj1.Getdata(10,20,30);
            Console.ReadLine();
        }
    }
}
