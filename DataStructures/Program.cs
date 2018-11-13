using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListImplementation;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList myList = new LinkedList();
            myList.AddNode(0);
            myList.AddNode(1);
            myList.AddNode(3);
            myList.AddNode(4);
            myList.AddNode(2, 2);
            myList.PrintAllNodes();

            Console.ReadKey();
        }
    }
}
