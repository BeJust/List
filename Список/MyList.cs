using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class MyList
    {
        public MyNode Head { get; set; }
        public int Count { get; set; }
        public MyNode Tail { get; set; }
       

        public void Add(int inf)
        {
            if (Count == 0)
            {
                Tail = new MyNode(inf,null,null);
                Head = Tail;
                

            }
            else
            {
                Tail.Next = new MyNode(inf,null,Tail);
                Tail = Tail.Next;

            }
            Count++;
        }
        
        public void Printer()
        {
            MyNode p = new MyNode();
            p = Head;
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(p.Inf);
                if (p.Next != null)
                {
                    p = p.Next;
                }
            }
        }
        public MyNode FindNode(int inf)
        {
            MyNode p = new MyNode();
            p = Head;
            bool ok = false;
            while((p != null) && (!ok))
            {
                ok = p.Inf == inf;
                if (!ok)
                    p = p.Next;
            }
            return p;
        }

        public void Delete(int inf)
        {
            MyNode p = new MyNode();
            p = Head;
            for (int i = 0; i < Count; i++)
            {
                if (p.Inf == inf)
                {
                    p.Prev.Next = p.Next;
                    p.Next = p.Next.Prev;
                    Count--;
                    return;
                }
                else
                {
                    p = p.Next;
                }
            }
            
        }

        public void Insert(MyNode p, int e)
        {
            if (Head == null)
            {
                Head = new MyNode(e, null, null);
                Head.Next = Head;
                Head.Prev = Head;
                
            }
            else
            {
                MyNode t = new MyNode(e, Head.Next, Head);
                Head.Next.Prev = t;
                Head.Next = t;
             
            }
            Count++;
        }
    }
}
