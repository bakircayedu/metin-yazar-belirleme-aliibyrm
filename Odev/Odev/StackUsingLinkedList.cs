using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
   public class StackUsingLinkedList
    {
        private class Node
        {
            public string data;
            public Node link;
        }
        Node top;

        public StackUsingLinkedList()
        {
            this.top = null;
        }

        public void push(string x)
        {
            Node temp = new Node();

            if (temp == null)
            {
                Console.Write("\nHeap Overflow");
                return;
            }
            temp.data = x;
            temp.link = top;
            top = temp;
        }


        public bool isEmpty()
        {
            return top == null;
        }

        public string peek()
        {
            if (!isEmpty())
            {
                return top.data;
            }
            else
            {
                Console.WriteLine("Stack is empty");
                return "-1";
            }
        }

        public void pop()
        {
            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }
            top = (top).link;
        }

        public void display()
        {
            if (top == null)
            {
                Console.Write("\nStack Underflow");
                return;
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {
                    Console.Write("{0}->", temp.data);
                    temp = temp.link;
                }
            }
        }
    }
}
