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

        public void PrintAllNodes()
        {
            Node current = headNode;

            while (current != null)
            {
                Console.Write("[" + current.data + "]");
                current = current.nextNode;
            }
        }

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

        public void AddNode(int position, int data)
        {
            Node toAdd = new Node();
            toAdd.data = data;

            if (position == this.Count() && !this.IsEmpty())
            {
                Node current = headNode;

                while (current.nextNode != null)
                {
                    current = current.nextNode;
                }

                current.nextNode = toAdd;
                toAdd.prevNode = current;
            }
            else if (position == 0)
            {
                if (this.IsEmpty())
                {
                    headNode = new Node();

                    headNode.data = data;
                }
                else
                {
                    Node linkNode = headNode;
                    headNode = toAdd;
                    headNode.nextNode = linkNode;
                    linkNode.prevNode = headNode;
                }
            }
            else
            {
                int checker = 0;

                Node prevNode = null;
                Node nextNode = null;

                Node current = headNode;
                while (checker != position)
                {
                    if (checker == position - 1)
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
                toAdd.prevNode = prevNode;
                toAdd.nextNode = nextNode;
                nextNode.prevNode = toAdd;
            }
        }

        public void Remove(int position)
        {
            if (position == 0)
            {
                Node linkNode = headNode.nextNode;
                headNode = null;
                headNode = linkNode;
            }
            else if (position == this.Count() - 1)
            {
                Node current = headNode;
                Node prevNode = null;

                while (current.nextNode != null)
                {
                    prevNode = current;
                    current = current.nextNode;
                }

                current = null;
                prevNode.nextNode = null;
            }
            else
            {
                int checker = 0;

                Node prevNode = null;
                Node nextNode = null;

                Node current = headNode;
                while (checker != position)
                {
                    if (checker == position - 1)
                    {
                        prevNode = current;
                    }

                    current = current.nextNode;
                    checker++;
                }

                nextNode = current.nextNode;

                current = null;

                nextNode.prevNode = prevNode;
                prevNode.nextNode = nextNode;
            }
        }

        public int GetData(int position)
        {
            int checker = 0;
            Node current = headNode;

            while (checker != position)
            {
                current = current.nextNode;
                checker++;
            }

            return current.data;
        }

        public void SetData(int position, int data)
        {
            int checker = 0;
            Node current = headNode;

            while (checker != position)
            {
                current = current.nextNode;
                checker++;
            }

            current.data = data;
        }

        public int Count()
        {
            if (headNode == null)
            {
                return 0;
            }
            else
            {
                int linkedListLength = 1;
                Node current = headNode;

                while (current.nextNode != null)
                {
                    current = current.nextNode;
                    linkedListLength++;
                }

                return linkedListLength;
            }
        }

        public bool IsEmpty()
        {
            return headNode == null ? true : false;
        }
    }
}
