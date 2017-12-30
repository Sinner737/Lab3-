using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Collections
{
    class Stack<T> : Collections<T>
    {
        private Node head;
        public Node Next;
        public Stack() //конструктор
        {
            head = null;
        }
        public Stack(T x) //конструктор
        {
            Node p = new Node(x);
            head = p;
        }

        public void Push(T x) //добавляем элемент х в стек
        {
            Node element = new Node(x);
            element.Next = head;
            head = element;
        }
        public void Write()
        {
            Write(head);
        }
        public void Clear() //удаляем
        {
            Clear(head);
        }
        public Stack<T> Pop()
        {
            if (head == null) return null;
            Stack<T> p = new Stack<T>(head.Data);
            head = head.Next;
            return p;
        }
        public Stack<T> Peek() //получение значения первого элемента без извлечения
        {
            if (head == null) return null;
            Stack<T> p = new Stack<T>(head.Data);
            return p;
        }
    }
}
