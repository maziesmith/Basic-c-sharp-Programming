using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorApp
{
    class Exercise
    {
        public Exercise(int a, int b) {
            if(a==b) 
            {

                int s = (a + b) * 3;
                Console.WriteLine(s);

            }
            else { 
            
            int s=a+b;
                Console.WriteLine(s);
            }
       }

        public int  Getdata(int a, int b ,int c) {
            int mul = a * b * c;
            Console.WriteLine(mul);
            return mul;
        
        
        }
        public Exercise() {

            Console.WriteLine("this is default constructor");
        
        }
        }


    }


