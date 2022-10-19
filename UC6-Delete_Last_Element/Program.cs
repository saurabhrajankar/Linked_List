using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC6_Delete_Last_Element
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }
    }
    public class LinkedList
    {
        Node head = null;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine(node.data + ":Inserted SuccessFully");
        }
        internal void poplast()
        {
            Node node = head;
            while (node.next.next != null)
            {
                node = node.next;
            }
            node.next = null;
            Console.WriteLine("Last Element Removed");
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList Is Empty");
            }
            else
            {
                Console.WriteLine("Values In LinkedList Are:");
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
    internal class LL6
    {
        static void Main(string[] args)
        {
            LinkedList l = new LinkedList();
            l.Add(56);
            l.Add(30);
            l.Add(70);
            Console.WriteLine("----------------------------------");
            l.Display();
            Console.WriteLine("----------------------------------");
            l.poplast();
            l.Display();
        }
    }
}