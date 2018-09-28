using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackApp
{
    class NewStack
    {
        public void GetStack() {
            Stack myStack = new Stack();
            myStack.Push(20);
            myStack.Push(4);
            myStack.Push(2);
            
            Console.WriteLine(myStack.Peek());
            Console.WriteLine(myStack.Contains(20));
            foreach (int i in myStack) {
                Console.WriteLine(i);
            
            }
        }



    }
}
