using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
       
        static void Main(string[] args)
        {
            MyList list = new MyList();
            MyNode p = new MyNode(5, null, null);
            for (int i = 0; i <= 10; i++)
                list.Add(i);
            list.Printer();
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("FindNode(5) = {0}", list.FindNode(5).Inf);
            Console.ReadKey();

            Console.WriteLine();
            list.Delete(p.Inf);
            list.Printer();
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Insert(p,55)");
            list.Insert(p,55);
            list.Printer();
            Console.ReadKey();

        }
    }
}
