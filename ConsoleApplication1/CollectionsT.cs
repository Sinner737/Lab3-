using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    abstract class Collections<T>
    {
        public class Node
        {
            private Node next;
            private T data;

            public Node(T t)
            {
                next = null;
                data = t;
            }
            public void delete()
            {
                next = default(Node);
                data = default(T);
            }
            public Node Next
            {
                get { return next; }
                set { next = value; }
            }
            public T Data
            {
                get { return data; }
                set { data = value; }
            }
        }
        public void Write(Node head)
        {
            Node curr = head;
            while (curr != null)
            {
                Console.Write(curr.Data + " ");
                curr = curr.Next;
            }
            Console.WriteLine();
        }
        public void Clear(Node head) //удаление коллекцию
        {
            Node p;
            while (head != null)
            {
                p = head;
                head = head.Next;
                p.delete();
            }
        }
    }
}