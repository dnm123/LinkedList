using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddToEnd(3);
            list.AddToEnd(8);
            list.AddToFront(5);
            list.DeleteFromEnd();
            list.DeleteFromHead();

            list.Display();
            Console.WriteLine(list.Search(7));


        }
    }
}
