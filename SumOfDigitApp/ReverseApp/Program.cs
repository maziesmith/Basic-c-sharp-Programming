using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseApp
{
    class Reverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a integar:");
            int num = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("the sum of integar is given below:");
            Reverse a = new Reverse();
            a.GetReverse(num);

        }
        public void GetReverse(int num) {

            int sum = 0;
           int r;
           while (num != 0) {
               r = num % 10;
               sum = sum * 10 + r;
               num = num / 10;
           
           }

           Console.WriteLine(sum);
           Console.ReadLine();
        }
    }
}
