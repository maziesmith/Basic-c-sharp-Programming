using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIstApp
{
    class NewList
    {
        public void GetList() {

            List<int> a = new List<int>();

            a.Add(100);
            a.Add(20);
            a.Add(500);
            a.Add(09);
            a.Add(30);
            Console.WriteLine("the values of List :");
            foreach (int i in a) {
                Console.WriteLine(i);

            }
            Console.WriteLine("sorted element:");
            a.Sort();
            foreach (int i in a) {
                Console.WriteLine(i);

            }
            Console.WriteLine("insert at firts position:");
            a.Insert(0, 1);

            foreach (int i in a)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine("Remove 500");
            a.Remove(500);
            foreach (int i in a)
            {
                Console.WriteLine(i);

            }

        }
    
    
    }


}
