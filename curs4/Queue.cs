using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curs4
{
    public class Queue : Tube
    {
        public Queue() : base()
        {

        }
        public void Push(int x)
        {
            addbeg(x);
        }
        public int Pop()
        {
            return delend();
        }
        public override void view()
        {
            Console.Write("Queue: ");
            base.view();
        }

    }
}
