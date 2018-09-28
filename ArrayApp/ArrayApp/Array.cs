using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayApp
{
    class Array
    {
        public void GetArray() {
            string[] arr = new String[3];
          // arr[0] = "Yunus";
            //arr[1] = "Ali";
            //arr[2] = "rony";
            for (int i = 0; i < arr.Length; i++) {

               arr[i]= Console.ReadLine();
           
            }
            foreach(string m in arr){
            Console.WriteLine(m);
            
            
            }


                //for (int i = 0; i < arr.Length; i++)
    
            //{
//
  //                  Console.Write(arr[i]);
 }



        
        
        
        }



    }

