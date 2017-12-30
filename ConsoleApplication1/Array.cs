using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Array<T> : Collections<T>
    {
        private Node head;
        public Array() //конструктор
        {
            head = null;
        }
        public Array(T x) //конструктор
        {
            Node p = new Node(x);
            head = p;
        }

        public void Write() //выводим в консоль
        {
            Write(head);
        }
        public void Clear() //удаляем
        {
            Clear(head);
        }
        public void Add(T x) //добавляем элемент
        {
            Node element = new Node(x);
            Node p = head;
            if (head == null)
                head = element;
            else
                while (p.Next != null)
                    p = p.Next;
            p.Next = element;
        }
        public void RemoveAt(int i)//удаляем i-й элемент (начиная с 0(!!!))
        {
            Node p = head, q = head;
            for (int j = 0; j != i; j++)
            {
                q = p;          //предыдущий
                p = p.Next;     //текущий
            }
            if (p == null) return;
            if (q == head)
            {
                q.delete();
                head = p;
            }
            else if (p.Next == null)
            {
                p.delete();
                q.Next = null;
            }
            else
            {
                q.Next = p.Next;
                p.delete();
            }
        }
        public void Remove() //удаляем первый элемент
        {
            Node p = head;
            head = head.Next;
            p.delete();
        }
    }
}
