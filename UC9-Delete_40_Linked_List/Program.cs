using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC9_Delete_40_Linked_List
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
        internal void delete(int value, int data)
        {
            Node node = head;
            while (node.data != value)
            {
                node = node.next;
            }
            node.next = node.next.next;

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
        internal void size()
        {
            int a = 0;
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList Is Empty");
            }
            else
            {
                while (temp != null)
                {
                    a++;
                    temp = temp.next;
                }
                Console.WriteLine("Size Is:" + a);
            }
        }
    }
    internal class LL9
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(40);
            list.Add(70);
            list.Display();
            Console.Write("Enter The Element You Have To Delete:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter The Previous Element Of That Element You Have To Delete:");
            int b = Convert.ToInt32(Console.ReadLine());
            list.delete(b, a);
            list.Display();
            list.size();
        }
    }
}
