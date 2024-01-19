using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSachLienKetDon
{
    class Node
    {
        private int info;
        private Node next;

        public Node(int x)
        {
            info = x;
            next = null;

        }

        public int Info
        {
            set { this.info = value; }
            get { return info; }
        }
        public Node Next
        {
            set { this.next = value; }
            get { return next; }

        }
    }
    class SingleLinkList
    {
        private Node Head;
        public SingleLinkList()
        {
            Head = null;
        }
        public void AddFirst(int x)
        {
            Node i = new Node(x);
            i.Next = Head;
            Head = i;
        }
        public void AddHead(int x)
        {
            Node i = new Node(x);
            i.Next = Head;
            Head = i;

        }
        public void Addlast(int x)
        {
            Node i = new Node(x);
            if( Head == null)
            {
                Head = i;

            }
            else
            {
                Node I = Head;
                while (I.Next!=null)
                {
                    I = I.Next;
                }
                I.Next = i;
            }
        }
        public void ProssecList()
        {
            Node i = Head;
            while (i != null)
            {
                Console.WriteLine("{i.info}");
                i = i.Next;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
