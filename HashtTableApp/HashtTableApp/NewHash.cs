using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtTableApp
{
    class NewHash
    {
        public void GetHastable() {
            Hashtable a = new Hashtable();
            a.Add(101, 500);
            a.Add(104, 1000);
            a.Add("fb", "rony");

            Console.WriteLine(a.ContainsKey("fb"));
            foreach (DictionaryEntry i in a)
            {
                Console.WriteLine("  key= {0} and value ={1}", i.Key,i.Value);

            
            }



        
        
        
        }


    }
}
