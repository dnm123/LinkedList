using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList<T> where T :IComparable
    {
        Node<T> head;

        public void AddToFront(T val)
        {
            Node<T> temp = new Node<T>(val);
            temp.Next = head;
            head = temp;
        }

        public void DeleteFromHead()
        {
            if (head!=null)
            {
                head = head.Next;
            }
        }

        public void DeleteFromEnd()
        {
            if (head==null|| head.Next==null)
                head = null;
            else
            {
                Node<T> iterator = head;
                Node<T> previous = head;

                while (iterator.Next != null)
                {
                    previous = iterator;
                    iterator = iterator.Next;
                }
                previous.Next = null;
            }

            //else
            //{
            //    Node<T> iterator = head;
            //    while (iterator.Next.Next!=null)
            //    {
            //        iterator = iterator.Next;
            //    }
            //    iterator.Next = null;

            //}

        }

        public void AddToEnd(T val)
        {
            Node<T> temp = new Node<T>(val);
            
            if (head==null)
            {
                head = temp;
            }
            else
            {
                Node<T> iterator = head;
                while (iterator.Next != null)
                    iterator = iterator.Next;
                iterator.Next = temp;
            }

        }

        public void Display()
        {
            Node<T> iterator = head;
            while (iterator!=null)
            {
                Console.WriteLine(iterator.Value);
                iterator = iterator.Next;
            }
            Console.WriteLine();

        }

        public bool Search(T val)
        {
            Node<T> iterator = head;
            while (iterator!= null)
            {
                if (iterator.Value.CompareTo(val) == 0)
                    return true;
                else
                    iterator = iterator.Next;
            }
            return false;

        }


    }
}
