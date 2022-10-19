using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC7_Search_Linklist
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
        internal string search(int data)
        {
            while (this.head != null)
            {
                if (this.head.data == data)
                {
                    Console.WriteLine("Element Found");
                    break;
                }
                this.head = this.head.next;
            }
            return "Element Not Found";
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
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Values In LinkedList Are:");
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
    internal class LL7
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            Console.WriteLine("---------------------");
            Console.Write("Enter The Element You Have To Search:");
            int a = Convert.ToInt32(Console.ReadLine());
            list.search(a);
        }
    }
}