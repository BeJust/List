using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class MyNode
    {
        public int Inf { get; set; }
        public MyNode Next { get; set; }
        public MyNode Prev { get; set; }

        public MyNode()
        {
        }

        public MyNode(int inf, MyNode next, MyNode prev)
        {
            this.Inf = inf;
            this.Next = next;
            this.Prev = prev;
        }
    }
}
