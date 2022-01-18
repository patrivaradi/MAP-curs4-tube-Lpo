using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs4
{
    public class Stack:Tube
    {
        public Stack():base()
        {

        }
        public void Push(int x)
        {
            addbeg(x);
        }
        public int Pop()
        {
           return delbeg();
        }
        public override void view()
        {
            Console.WriteLine("Stack : ");
            base.view();
        }

    }
   
}
