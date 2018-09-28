using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigitApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a integar:");
            int num = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("the sum of integar is given below:");
            Program a = new Program();
            a.GetSum(num);


        }
        public void GetSum(int num)
        {

            int sum = 0, r;
            while (num != 0)
            {
                r = num % 10;
                sum = sum + r;
                num = num / 10;
            }

            Console.WriteLine(sum);
                Console.ReadLine();
        
        }

    }

}
    


