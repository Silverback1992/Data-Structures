using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListImplementation;
using StackImplementation;
using DoublyLinkedListImplementation;
using QueueImplementation;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Linked Lists

            Console.WriteLine("Linked List Check:");

            LinkedList myList = new LinkedList();
            myList.AddNode(0);
            myList.AddNode(1);
            myList.AddNode(3);
            myList.AddNode(4);
            myList.AddNode(2, 2);
            myList.PrintAllNodes();

            Console.WriteLine();
            Console.WriteLine();

            //Doubly Linked Lists

            Console.WriteLine("Doubly Linked List Check:");

            DoublyLinkedList myDoublyList = new DoublyLinkedList();
            myDoublyList.AddNode(3);
            myDoublyList.AddNode(10);
            myDoublyList.AddNode(5);
            myDoublyList.PrintAllNodes();

            Console.WriteLine();
            Console.WriteLine();

            //Stacks

            Console.WriteLine("Stack Check:");

            Stack myStack = new Stack();
            if(!myStack.IsEmpty())
            {
                myStack.Top();
            }
            Console.WriteLine(myStack.IsEmpty());
            myStack.Push(5);
            myStack.Push(3);
            myStack.Push(10);
            myStack.Pop();
            myStack.Pop();
            myStack.Push(99);
            Console.WriteLine(myStack.Top());
            Console.WriteLine(myStack.IsEmpty());

            Console.WriteLine();

            //Queues

            Console.WriteLine("Queue Check:");

            Queue myQueue = new Queue();
            if(!myQueue.IsEmpty())
            {
                Console.WriteLine(myQueue.Front());
            }
            myQueue.EnQueue(5);
            myQueue.EnQueue(10);
            if(!myQueue.IsEmpty())
            {
                Console.WriteLine(myQueue.Front());
            }
            Console.WriteLine(myQueue.DeQueue());
            myQueue.EnQueue(3);
            myQueue.EnQueue(7);
            myQueue.EnQueue(50);
            myQueue.EnQueue(99);
            Console.WriteLine(myQueue.DeQueue());
            Console.WriteLine(myQueue.DeQueue());
            if (!myQueue.IsEmpty())
            {
                Console.WriteLine(myQueue.Front());
            }
            myQueue.EnQueue(13);
            if (!myQueue.IsEmpty())
            {
                Console.WriteLine(myQueue.Front());
            }

            Console.WriteLine();

            //Trees

            //Graphs

            Console.ReadKey();
        }
    }
}
