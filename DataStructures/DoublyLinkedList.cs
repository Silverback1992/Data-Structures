using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListImplementation
{
    class Node
    {
        public Node prevNode;
        public int data;
        public Node nextNode;
    }

    class DoublyLinkedList
    {
        private Node headNode;

        public void AddNode(int data)
        {
            if(headNode == null)
            {
                headNode = new Node();

                headNode.data = data;
                headNode.prevNode = null;
                headNode.nextNode = null;
            }
            else
            {
                Node current = headNode;

                Node toAdd = new Node();
                toAdd.data = data;

                while (current.nextNode != null)
                {
                    current = current.nextNode;
                }

                current.nextNode = toAdd;
                toAdd.prevNode = current;
            }
        }

        public void PrintAllNodes()
        {
            Node current = headNode;

            while(current.nextNode != null)
            {
                Console.Write("[" + current.data + "]");
                current = current.nextNode;
            }
        }
    }
}
