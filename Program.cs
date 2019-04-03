using System;

namespace DoublyLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DLinkedLists ls = new DLinkedLists();
            ls.Add(1);
            ls.Add(2);
            ls.Add(3);
            ls.Add(4);

            ls.PrintValues();

            ls.Reverse();

            System.Console.WriteLine("--------------------");

            ls.PrintValues();
        }
    }
}
