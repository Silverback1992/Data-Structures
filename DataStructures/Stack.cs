using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImplementation
{
    class StackElement
    {
        public int data;
        public StackElement nextElement;
    }

    class Stack
    {
        private StackElement firstElement;

        public void Push(int data)
        {
            if(IsEmpty())
            {
                firstElement = new StackElement();
                firstElement.data = data;
                firstElement.nextElement = null;
            }
            else
            {
                StackElement newElement = new StackElement();
                newElement.data = data;

                StackElement current = firstElement;

                while(current.nextElement != null)
                {
                    current = current.nextElement;
                }

                current.nextElement = newElement;
            }
        }

        public void Pop()
        {
            StackElement current = firstElement;

            if (current.nextElement != null)
            {
                while (current.nextElement.nextElement != null)
                {
                    current = current.nextElement;
                }

                current.nextElement = null;
            }
            else
            {
                current = null;
            }
        }

        public int Top()
        {
            StackElement current = firstElement;

            while(current.nextElement != null)
            {
                current = current.nextElement;
            }

            return current.data;
        }

        public bool IsEmpty()
        {
            return firstElement == null ? true : false;
        }
    }
}
