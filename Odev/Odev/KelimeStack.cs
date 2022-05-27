using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    public class KelimeStack
    {
        private class Node
        {
            public string data;
            public Node link;
            public int metinSiklik;

        }
        Node top;

        public KelimeStack()
        {
            this.top = null;
        }

        public void push(string x,int metinSiklik)
        {
            Node temp = new Node();

            if (temp == null)
            {
                Console.Write("\nHeap Overflow");
                return;
            }
            temp.data = x;
            temp.metinSiklik = metinSiklik;
            temp.link = top;
            top = temp;
        }

        public bool isEmpty()
        {
            return top == null;
        }

        public string peek()
        {
            string sonuc ="Kelime:"+ top.data+"\n" +"Metin Tekrar Sayısı:" + top.metinSiklik.ToString();
            if (!isEmpty())
            {
                return sonuc;
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

