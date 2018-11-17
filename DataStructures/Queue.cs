using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueImplementation
{
    class Node
    {
        public int data;
        public Node nextNode;
    }

    class Queue
    {
        private Node headNode;

        public void EnQueue(int data)
        {
            if(headNode == null)
            {
                headNode = new Node();
                headNode.data = data;
                headNode.nextNode = null;
            }
            else
            {
                Node current = headNode;

                Node toAdd = new Node();
                toAdd.data = data;

                while(current.nextNode != null)
                {
                    current = current.nextNode;
                }

                current.nextNode = toAdd;
            }
        }

        public int DeQueue()
        {
            int valueToReturn = headNode.data;
            headNode = headNode.nextNode;

            return valueToReturn;
        }

        public int Front()
        {
            return headNode.data;
        }

        public bool IsEmpty()
        {
            return headNode == null ? true : false;
        }
    }
}
