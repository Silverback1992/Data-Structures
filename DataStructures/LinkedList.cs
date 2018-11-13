using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListImplementation
{
    class Node
    {
        public int data;
        public Node nextNode;
    }

    class LinkedList
    {
        private Node headNode;

        public void PrintAllNodes()
        {
            Node current = headNode;

            while (current != null)
            {
                Console.Write("["+current.data+"]");
                current = current.nextNode;
            }
        }

        public void AddNode(int data)
        {
            if (headNode == null)
            {
                headNode = new Node();

                headNode.data = data;
                headNode.nextNode = null;
            }
            else
            {
                Node toAdd = new Node();
                toAdd.data = data;

                Node current = headNode;

                while (current.nextNode != null)
                {
                    current = current.nextNode;
                }

                current.nextNode = toAdd;
            }
        }

        public void AddNode(int data, int position)
        {
            int checker = 0;

            Node toAdd = new Node();
            toAdd.data = data;
            Node prevNode = null;
            Node nextNode = null;

            Node current = headNode;
            while(checker != position)
            {
                if(checker == position-1)
                {
                    prevNode = current;
                }

                current = current.nextNode;
                checker++;

                if (checker == position)
                {
                    nextNode = current;
                }
            }

            prevNode.nextNode = toAdd;
            toAdd.nextNode = nextNode;
        }
    }
}
