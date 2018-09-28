using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloadingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator obj = new Calculator();

            double b=obj.Add(10, 20, 30);

            Console.WriteLine(b);
            Console.WriteLine(obj.Subtract(40, 50));
            Console.WriteLine(obj.Divide(20, 8));
            Console.WriteLine(obj.Multiply(20, 40));
            Console.ReadLine();

        }
    }
}
