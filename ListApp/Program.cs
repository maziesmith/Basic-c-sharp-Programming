using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = new ArrayList();

            a.Add(10);
            a.Add(60);
            a.Add(9);
            a.Add(1);
            a.Add(100);

                foreach (var i in a)
                {
                    Console.WriteLine(i);
              
              
               }
                //a.Reverse();
                a.Sort();
            foreach(var i in a){
                Console.WriteLine(i);
            }
          
                Console.ReadLine();
        }
    }
}
